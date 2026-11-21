using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using Google.Protobuf;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F8E RID: 12174
	[NullableContext(2)]
	[Nullable(0)]
	public class ChairPresentationNet : IStaticVariableResetter
	{
		// Token: 0x0601CDD7 RID: 118231 RVA: 0x008D199A File Offset: 0x008CFB9A
		static ChairPresentationNet()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ChairPresentationNet.CreateStaticDefaultValue), new Action(ChairPresentationNet.ResetStaticDefaultValue));
		}

		// Token: 0x0601CDD8 RID: 118232 RVA: 0x008D19B9 File Offset: 0x008CFBB9
		public static void CreateStaticDefaultValue()
		{
			ChairPresentationNet.PresentationSnapshots = new Dictionary<ValueTuple<int, long>, ChairPresentationNet.ChairPresentationSnapshot>();
		}

		// Token: 0x0601CDD9 RID: 118233 RVA: 0x008D19C5 File Offset: 0x008CFBC5
		public static void ResetStaticDefaultValue()
		{
			ChairPresentationNet.PresentationSnapshots = null;
		}

		// Token: 0x0601CDDA RID: 118234 RVA: 0x008D19D0 File Offset: 0x008CFBD0
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

		// Token: 0x0601CDDB RID: 118235 RVA: 0x008D1A70 File Offset: 0x008CFC70
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

		// Token: 0x0601CDDC RID: 118236 RVA: 0x008D1AD4 File Offset: 0x008CFCD4
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

		// Token: 0x0601CDDD RID: 118237 RVA: 0x008D1B32 File Offset: 0x008CFD32
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

		// Token: 0x0601CDDE RID: 118238 RVA: 0x008D1B58 File Offset: 0x008CFD58
		private static void RemovePlayerSnapshots(int playerId)
		{
			if (playerId <= 0 || ChairPresentationNet.PresentationSnapshots == null)
			{
				return;
			}
			ValueTuple<int, long>[] array = new ValueTuple<int, long>[ChairPresentationNet.PresentationSnapshots.Count];
			ChairPresentationNet.PresentationSnapshots.Keys.CopyTo(array, 0);
			foreach (ValueTuple<int, long> valueTuple in array)
			{
				if (valueTuple.Item1 == playerId)
				{
					ChairPresentationNet.PresentationSnapshots.Remove(valueTuple);
				}
			}
		}

		// Token: 0x0601CDDF RID: 118239 RVA: 0x008D1BC0 File Offset: 0x008CFDC0
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

		// Token: 0x0601CDE0 RID: 118240 RVA: 0x008D1C10 File Offset: 0x008CFE10
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

		// Token: 0x0601CDE1 RID: 118241 RVA: 0x008D1CCC File Offset: 0x008CFECC
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

		// Token: 0x0400F375 RID: 62325
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

		// Token: 0x02008C29 RID: 35881
		[Nullable(0)]
		public sealed class ChairPresentationSnapshot : IEquatable<ChairPresentationNet.ChairPresentationSnapshot>
		{
			// Token: 0x06042C7A RID: 273530 RVA: 0x013DD7AF File Offset: 0x013DB9AF
			public ChairPresentationSnapshot(int PlayerId, long ChairCreatureDataId, bool IsShow, Aki.Protocol.Vector Location, Aki.Protocol.Rotator Rotation)
			{
				this.PlayerId = PlayerId;
				this.ChairCreatureDataId = ChairCreatureDataId;
				this.IsShow = IsShow;
				this.Location = Location;
				this.Rotation = Rotation;
				base..ctor();
			}

			// Token: 0x170078CF RID: 30927
			// (get) Token: 0x06042C7B RID: 273531 RVA: 0x013DD7DC File Offset: 0x013DB9DC
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

			// Token: 0x170078D0 RID: 30928
			// (get) Token: 0x06042C7C RID: 273532 RVA: 0x013DD7E8 File Offset: 0x013DB9E8
			// (set) Token: 0x06042C7D RID: 273533 RVA: 0x013DD7F0 File Offset: 0x013DB9F0
			public int PlayerId { get; set; }

			// Token: 0x170078D1 RID: 30929
			// (get) Token: 0x06042C7E RID: 273534 RVA: 0x013DD7F9 File Offset: 0x013DB9F9
			// (set) Token: 0x06042C7F RID: 273535 RVA: 0x013DD801 File Offset: 0x013DBA01
			public long ChairCreatureDataId { get; set; }

			// Token: 0x170078D2 RID: 30930
			// (get) Token: 0x06042C80 RID: 273536 RVA: 0x013DD80A File Offset: 0x013DBA0A
			// (set) Token: 0x06042C81 RID: 273537 RVA: 0x013DD812 File Offset: 0x013DBA12
			public bool IsShow { get; set; }

			// Token: 0x170078D3 RID: 30931
			// (get) Token: 0x06042C82 RID: 273538 RVA: 0x013DD81B File Offset: 0x013DBA1B
			// (set) Token: 0x06042C83 RID: 273539 RVA: 0x013DD823 File Offset: 0x013DBA23
			public Aki.Protocol.Vector Location { get; set; }

			// Token: 0x170078D4 RID: 30932
			// (get) Token: 0x06042C84 RID: 273540 RVA: 0x013DD82C File Offset: 0x013DBA2C
			// (set) Token: 0x06042C85 RID: 273541 RVA: 0x013DD834 File Offset: 0x013DBA34
			public Aki.Protocol.Rotator Rotation { get; set; }

			// Token: 0x06042C86 RID: 273542 RVA: 0x013DD840 File Offset: 0x013DBA40
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

			// Token: 0x06042C87 RID: 273543 RVA: 0x013DD88C File Offset: 0x013DBA8C
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

			// Token: 0x06042C88 RID: 273544 RVA: 0x013DD946 File Offset: 0x013DBB46
			[CompilerGenerated]
			public static bool operator !=(ChairPresentationNet.ChairPresentationSnapshot left, ChairPresentationNet.ChairPresentationSnapshot right)
			{
				return !(left == right);
			}

			// Token: 0x06042C89 RID: 273545 RVA: 0x013DD952 File Offset: 0x013DBB52
			[CompilerGenerated]
			public static bool operator ==(ChairPresentationNet.ChairPresentationSnapshot left, ChairPresentationNet.ChairPresentationSnapshot right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x06042C8A RID: 273546 RVA: 0x013DD968 File Offset: 0x013DBB68
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return ((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<PlayerId>k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(this.<ChairCreatureDataId>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsShow>k__BackingField)) * -1521134295 + EqualityComparer<Aki.Protocol.Vector>.Default.GetHashCode(this.<Location>k__BackingField)) * -1521134295 + EqualityComparer<Aki.Protocol.Rotator>.Default.GetHashCode(this.<Rotation>k__BackingField);
			}

			// Token: 0x06042C8B RID: 273547 RVA: 0x013DD9F8 File Offset: 0x013DBBF8
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as ChairPresentationNet.ChairPresentationSnapshot);
			}

			// Token: 0x06042C8C RID: 273548 RVA: 0x013DDA08 File Offset: 0x013DBC08
			[CompilerGenerated]
			public bool Equals(ChairPresentationNet.ChairPresentationSnapshot other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<PlayerId>k__BackingField, other.<PlayerId>k__BackingField) && EqualityComparer<long>.Default.Equals(this.<ChairCreatureDataId>k__BackingField, other.<ChairCreatureDataId>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsShow>k__BackingField, other.<IsShow>k__BackingField) && EqualityComparer<Aki.Protocol.Vector>.Default.Equals(this.<Location>k__BackingField, other.<Location>k__BackingField) && EqualityComparer<Aki.Protocol.Rotator>.Default.Equals(this.<Rotation>k__BackingField, other.<Rotation>k__BackingField));
			}

			// Token: 0x06042C8E RID: 273550 RVA: 0x013DDAB8 File Offset: 0x013DBCB8
			[CompilerGenerated]
			private ChairPresentationSnapshot([Nullable(1)] ChairPresentationNet.ChairPresentationSnapshot original)
			{
				this.PlayerId = original.<PlayerId>k__BackingField;
				this.ChairCreatureDataId = original.<ChairCreatureDataId>k__BackingField;
				this.IsShow = original.<IsShow>k__BackingField;
				this.Location = original.<Location>k__BackingField;
				this.Rotation = original.<Rotation>k__BackingField;
			}

			// Token: 0x06042C8F RID: 273551 RVA: 0x013DDB07 File Offset: 0x013DBD07
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

		// Token: 0x02008C2A RID: 35882
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C607 RID: 181767
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__OnChairPresentationChangeNotify;

			// Token: 0x0402C608 RID: 181768
			[Nullable(0)]
			public static Action<int> <1>__RemovePlayerSnapshots;
		}
	}
}
