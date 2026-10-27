using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using Google.Protobuf;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044BC RID: 17596
	[NullableContext(2)]
	[Nullable(0)]
	public class ChairPresentationNet : IStaticVariableResetter
	{
		// Token: 0x0602D5B1 RID: 185777 RVA: 0x00A3B242 File Offset: 0x00A39442
		static ChairPresentationNet()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ChairPresentationNet.CreateStaticDefaultValue), new Action(ChairPresentationNet.ResetStaticDefaultValue));
		}

		// Token: 0x0602D5B2 RID: 185778 RVA: 0x00A3B261 File Offset: 0x00A39461
		public static void CreateStaticDefaultValue()
		{
			ChairPresentationNet.PresentationSnapshots = new Dictionary<ValueTuple<int, long>, ChairPresentationNet.ChairPresentationSnapshot>();
		}

		// Token: 0x0602D5B3 RID: 185779 RVA: 0x00A3B26D File Offset: 0x00A3946D
		public static void ResetStaticDefaultValue()
		{
			ChairPresentationNet.PresentationSnapshots = null;
		}

		// Token: 0x0602D5B4 RID: 185780 RVA: 0x00A3B278 File Offset: 0x00A39478
		public static void SendChairPresentationPush(long chairCreatureDataId, bool isShow, global::Vector location = null, global::Rotator rotation = null)
		{
			FollowerChairPresentationPush followerChairPresentationPush = FollowerChairPresentationPush.Create();
			followerChairPresentationPush.EntityId = chairCreatureDataId;
			followerChairPresentationPush.IsShow = isShow;
			if (isShow && location != null && rotation != null)
			{
				Aki.Protocol.Vector vector = Aki.Protocol.Vector.Create();
				vector.X = (float)location.X;
				vector.Y = (float)location.Y;
				vector.Z = (float)location.Z;
				followerChairPresentationPush.Location = vector;
				Aki.Protocol.Rotator rotator = Aki.Protocol.Rotator.Create();
				rotator.Pitch = rotation.Pitch;
				rotator.Yaw = rotation.Yaw;
				rotator.Roll = rotation.Roll;
				followerChairPresentationPush.Rotation = rotator;
			}
			Net.Instance.Send(EPushMessageId.FollowerChairPresentationPush, followerChairPresentationPush);
		}

		// Token: 0x0602D5B5 RID: 185781 RVA: 0x00A3B318 File Offset: 0x00A39518
		public static void Register()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.FollowerChairPresentationChangeNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = ChairPresentationNet.<>O.<0>__OnChairPresentationChangeNotify) == null)
			{
				callback = (ChairPresentationNet.<>O.<0>__OnChairPresentationChangeNotify = new Action<IMessage, Net.CallbackStatus>(ChairPresentationNet.OnChairPresentationChangeNotify));
			}
			instance.Register(id, callback);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name = EEventName.ScenePlayerLeaveScene;
			Action<int> handle;
			if ((handle = ChairPresentationNet.<>O.<1>__RemovePlayerSnapshots) == null)
			{
				handle = (ChairPresentationNet.<>O.<1>__RemovePlayerSnapshots = new Action<int>(ChairPresentationNet.RemovePlayerSnapshots));
			}
			instance2.Add<int>(name, handle);
		}

		// Token: 0x0602D5B6 RID: 185782 RVA: 0x00A3B37C File Offset: 0x00A3957C
		public static void UnRegister()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FollowerChairPresentationChangeNotify);
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ScenePlayerLeaveScene;
			Action<int> handle;
			if ((handle = ChairPresentationNet.<>O.<1>__RemovePlayerSnapshots) == null)
			{
				handle = (ChairPresentationNet.<>O.<1>__RemovePlayerSnapshots = new Action<int>(ChairPresentationNet.RemovePlayerSnapshots));
			}
			instance.Remove<int>(name, handle);
			Dictionary<ValueTuple<int, long>, ChairPresentationNet.ChairPresentationSnapshot> presentationSnapshots = ChairPresentationNet.PresentationSnapshots;
			if (presentationSnapshots != null)
			{
				presentationSnapshots.Clear();
			}
			ChairPresentationNet.PresentationSnapshots = null;
		}

		// Token: 0x0602D5B7 RID: 185783 RVA: 0x00A3B3DA File Offset: 0x00A395DA
		public static void RemoveSnapshot(int playerId, long chairCreatureDataId)
		{
			if (playerId <= 0 || chairCreatureDataId <= 0L)
			{
				return;
			}
			Dictionary<ValueTuple<int, long>, ChairPresentationNet.ChairPresentationSnapshot> presentationSnapshots = ChairPresentationNet.PresentationSnapshots;
			if (presentationSnapshots == null)
			{
				return;
			}
			presentationSnapshots.Remove(new ValueTuple<int, long>(playerId, chairCreatureDataId));
		}

		// Token: 0x0602D5B8 RID: 185784 RVA: 0x00A3B400 File Offset: 0x00A39600
		private static void RemovePlayerSnapshots(int playerId)
		{
			if (playerId <= 0 || ChairPresentationNet.PresentationSnapshots == null)
			{
				return;
			}
			foreach (ValueTuple<int, long> valueTuple in ChairPresentationNet.PresentationSnapshots.Keys.ToArray<ValueTuple<int, long>>())
			{
				if (valueTuple.Item1 == playerId)
				{
					ChairPresentationNet.PresentationSnapshots.Remove(valueTuple);
				}
			}
		}

		// Token: 0x0602D5B9 RID: 185785 RVA: 0x00A3B454 File Offset: 0x00A39654
		[NullableContext(1)]
		public static bool ApplyCachedPresentation(int playerId, long chairCreatureDataId, IPlayerFollowerChairHandler chairHandler)
		{
			ChairPresentationNet.ChairPresentationSnapshot chairPresentationSnapshot;
			if (ChairPresentationNet.PresentationSnapshots == null || !ChairPresentationNet.PresentationSnapshots.TryGetValue(new ValueTuple<int, long>(playerId, chairCreatureDataId), out chairPresentationSnapshot))
			{
				return false;
			}
			if (chairHandler.GetChairCreatureDataId() != chairCreatureDataId)
			{
				return false;
			}
			chairHandler.OnRemoteChairPresentationNotify(chairCreatureDataId, chairPresentationSnapshot.IsShow, chairPresentationSnapshot.Location, chairPresentationSnapshot.Rotation);
			return true;
		}

		// Token: 0x0602D5BA RID: 185786 RVA: 0x00A3B4A4 File Offset: 0x00A396A4
		[NullableContext(1)]
		[return: Nullable(2)]
		public static ChairPresentationNet.ChairPresentationSnapshot FindNearbyShownChair(long chairCreatureDataId, global::Vector location, double minDistanceSquared)
		{
			if (minDistanceSquared <= 0.0 || ChairPresentationNet.PresentationSnapshots == null)
			{
				return null;
			}
			foreach (ChairPresentationNet.ChairPresentationSnapshot chairPresentationSnapshot in ChairPresentationNet.PresentationSnapshots.Values)
			{
				if (chairPresentationSnapshot.IsShow && chairPresentationSnapshot.ChairCreatureDataId != chairCreatureDataId && chairPresentationSnapshot.Location != null)
				{
					global::Vector v = global::Vector.Create((double)chairPresentationSnapshot.Location.X, (double)chairPresentationSnapshot.Location.Y, (double)chairPresentationSnapshot.Location.Z);
					if (global::Vector.DistSquared(location, v) < minDistanceSquared)
					{
						return chairPresentationSnapshot;
					}
				}
			}
			return null;
		}

		// Token: 0x0602D5BB RID: 185787 RVA: 0x00A3B560 File Offset: 0x00A39760
		private unsafe static void OnChairPresentationChangeNotify(IMessage message, Net.CallbackStatus _)
		{
			FollowerChairPresentationChangeNotify followerChairPresentationChangeNotify = message as FollowerChairPresentationChangeNotify;
			if (followerChairPresentationChangeNotify == null)
			{
				return;
			}
			int playerId = followerChairPresentationChangeNotify.PlayerId;
			long entityId = followerChairPresentationChangeNotify.EntityId;
			if (playerId <= 0 || entityId <= 0L)
			{
				return;
			}
			if (ChairPresentationNet.PresentationSnapshots == null)
			{
				ChairPresentationNet.PresentationSnapshots = new Dictionary<ValueTuple<int, long>, ChairPresentationNet.ChairPresentationSnapshot>();
			}
			ChairPresentationNet.PresentationSnapshots[new ValueTuple<int, long>(playerId, entityId)] = new ChairPresentationNet.ChairPresentationSnapshot(playerId, entityId, followerChairPresentationChangeNotify.IsShow, followerChairPresentationChangeNotify.Location, followerChairPresentationChangeNotify.Rotation);
			IPlayerFollowerChairHandler playerFollowHandler = FollowUtils.GetPlayerFollowHandler<IPlayerFollowerChairHandler>(playerId);
			if (playerFollowHandler == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message2 = "[ChairPresentationNet] 收到椅子表现 Notify 但找不到 ChairHandler";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", playerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ChairCreatureDataId", entityId);
				instance.Warn(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (playerFollowHandler.GetChairCreatureDataId() != entityId)
			{
				return;
			}
			playerFollowHandler.OnRemoteChairPresentationNotify(entityId, followerChairPresentationChangeNotify.IsShow, followerChairPresentationChangeNotify.Location, followerChairPresentationChangeNotify.Rotation);
		}

		// Token: 0x040183EB RID: 99307
		[TupleElementNames(new string[]
		{
			"PlayerId",
			"ChairCreatureDataId"
		})]
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private static Dictionary<ValueTuple<int, long>, ChairPresentationNet.ChairPresentationSnapshot> PresentationSnapshots;

		// Token: 0x0200A708 RID: 42760
		[Nullable(0)]
		public sealed class ChairPresentationSnapshot : IEquatable<ChairPresentationNet.ChairPresentationSnapshot>
		{
			// Token: 0x0604C7BD RID: 313277 RVA: 0x014308E3 File Offset: 0x0142EAE3
			public ChairPresentationSnapshot(int PlayerId, long ChairCreatureDataId, bool IsShow, Aki.Protocol.Vector Location, Aki.Protocol.Rotator Rotation)
			{
				this.PlayerId = PlayerId;
				this.ChairCreatureDataId = ChairCreatureDataId;
				this.IsShow = IsShow;
				this.Location = Location;
				this.Rotation = Rotation;
				base..ctor();
			}

			// Token: 0x1700A140 RID: 41280
			// (get) Token: 0x0604C7BE RID: 313278 RVA: 0x01430910 File Offset: 0x0142EB10
			[Nullable(1)]
			[CompilerGenerated]
			private Type EqualityContract
			{
				[NullableContext(1)]
				[CompilerGenerated]
				get
				{
					return typeof(ChairPresentationNet.ChairPresentationSnapshot);
				}
			}

			// Token: 0x1700A141 RID: 41281
			// (get) Token: 0x0604C7BF RID: 313279 RVA: 0x0143091C File Offset: 0x0142EB1C
			// (set) Token: 0x0604C7C0 RID: 313280 RVA: 0x01430924 File Offset: 0x0142EB24
			public int PlayerId { get; set; }

			// Token: 0x1700A142 RID: 41282
			// (get) Token: 0x0604C7C1 RID: 313281 RVA: 0x0143092D File Offset: 0x0142EB2D
			// (set) Token: 0x0604C7C2 RID: 313282 RVA: 0x01430935 File Offset: 0x0142EB35
			public long ChairCreatureDataId { get; set; }

			// Token: 0x1700A143 RID: 41283
			// (get) Token: 0x0604C7C3 RID: 313283 RVA: 0x0143093E File Offset: 0x0142EB3E
			// (set) Token: 0x0604C7C4 RID: 313284 RVA: 0x01430946 File Offset: 0x0142EB46
			public bool IsShow { get; set; }

			// Token: 0x1700A144 RID: 41284
			// (get) Token: 0x0604C7C5 RID: 313285 RVA: 0x0143094F File Offset: 0x0142EB4F
			// (set) Token: 0x0604C7C6 RID: 313286 RVA: 0x01430957 File Offset: 0x0142EB57
			public Aki.Protocol.Vector Location { get; set; }

			// Token: 0x1700A145 RID: 41285
			// (get) Token: 0x0604C7C7 RID: 313287 RVA: 0x01430960 File Offset: 0x0142EB60
			// (set) Token: 0x0604C7C8 RID: 313288 RVA: 0x01430968 File Offset: 0x0142EB68
			public Aki.Protocol.Rotator Rotation { get; set; }

			// Token: 0x0604C7C9 RID: 313289 RVA: 0x01430974 File Offset: 0x0142EB74
			[NullableContext(1)]
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("ChairPresentationSnapshot");
				stringBuilder.Append(" { ");
				if (this.PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x0604C7CA RID: 313290 RVA: 0x014309C0 File Offset: 0x0142EBC0
			[NullableContext(1)]
			[CompilerGenerated]
			private bool PrintMembers(StringBuilder builder)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				builder.Append("PlayerId = ");
				builder.Append(this.PlayerId.ToString());
				builder.Append(", ChairCreatureDataId = ");
				builder.Append(this.ChairCreatureDataId.ToString());
				builder.Append(", IsShow = ");
				builder.Append(this.IsShow.ToString());
				builder.Append(", Location = ");
				builder.Append(this.Location);
				builder.Append(", Rotation = ");
				builder.Append(this.Rotation);
				return true;
			}

			// Token: 0x0604C7CB RID: 313291 RVA: 0x01430A7A File Offset: 0x0142EC7A
			[CompilerGenerated]
			public static bool operator !=(ChairPresentationNet.ChairPresentationSnapshot left, ChairPresentationNet.ChairPresentationSnapshot right)
			{
				return !(left == right);
			}

			// Token: 0x0604C7CC RID: 313292 RVA: 0x01430A86 File Offset: 0x0142EC86
			[CompilerGenerated]
			public static bool operator ==(ChairPresentationNet.ChairPresentationSnapshot left, ChairPresentationNet.ChairPresentationSnapshot right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x0604C7CD RID: 313293 RVA: 0x01430A9C File Offset: 0x0142EC9C
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<PlayerId>k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(this.<ChairCreatureDataId>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsShow>k__BackingField)) * -1521134295 + EqualityComparer<Aki.Protocol.Vector>.Default.GetHashCode(this.<Location>k__BackingField)) * -1521134295 + EqualityComparer<Aki.Protocol.Rotator>.Default.GetHashCode(this.<Rotation>k__BackingField);
			}

			// Token: 0x0604C7CE RID: 313294 RVA: 0x01430B2C File Offset: 0x0142ED2C
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as ChairPresentationNet.ChairPresentationSnapshot);
			}

			// Token: 0x0604C7CF RID: 313295 RVA: 0x01430B3C File Offset: 0x0142ED3C
			[CompilerGenerated]
			public bool Equals(ChairPresentationNet.ChairPresentationSnapshot other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<PlayerId>k__BackingField, other.<PlayerId>k__BackingField) && EqualityComparer<long>.Default.Equals(this.<ChairCreatureDataId>k__BackingField, other.<ChairCreatureDataId>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsShow>k__BackingField, other.<IsShow>k__BackingField) && EqualityComparer<Aki.Protocol.Vector>.Default.Equals(this.<Location>k__BackingField, other.<Location>k__BackingField) && EqualityComparer<Aki.Protocol.Rotator>.Default.Equals(this.<Rotation>k__BackingField, other.<Rotation>k__BackingField));
			}

			// Token: 0x0604C7D1 RID: 313297 RVA: 0x01430BEC File Offset: 0x0142EDEC
			[CompilerGenerated]
			private ChairPresentationSnapshot([Nullable(1)] ChairPresentationNet.ChairPresentationSnapshot original)
			{
				this.PlayerId = original.<PlayerId>k__BackingField;
				this.ChairCreatureDataId = original.<ChairCreatureDataId>k__BackingField;
				this.IsShow = original.<IsShow>k__BackingField;
				this.Location = original.<Location>k__BackingField;
				this.Rotation = original.<Rotation>k__BackingField;
			}

			// Token: 0x0604C7D2 RID: 313298 RVA: 0x01430C3B File Offset: 0x0142EE3B
			[CompilerGenerated]
			public void Deconstruct(out int PlayerId, out long ChairCreatureDataId, out bool IsShow, out Aki.Protocol.Vector Location, out Aki.Protocol.Rotator Rotation)
			{
				PlayerId = this.PlayerId;
				ChairCreatureDataId = this.ChairCreatureDataId;
				IsShow = this.IsShow;
				Location = this.Location;
				Rotation = this.Rotation;
			}
		}

		// Token: 0x0200A709 RID: 42761
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403273B RID: 206651
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__OnChairPresentationChangeNotify;

			// Token: 0x0403273C RID: 206652
			[Nullable(0)]
			public static Action<int> <1>__RemovePlayerSnapshots;
		}
	}
}
