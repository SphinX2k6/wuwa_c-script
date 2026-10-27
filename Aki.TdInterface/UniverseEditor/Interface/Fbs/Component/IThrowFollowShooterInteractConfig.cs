using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A64 RID: 23140
	public struct IThrowFollowShooterInteractConfig : IFlatbufferObject
	{
		// Token: 0x1700AE1C RID: 44572
		// (get) Token: 0x060275E9 RID: 161257 RVA: 0x0056AE36 File Offset: 0x00569036
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060275EA RID: 161258 RVA: 0x0056AE43 File Offset: 0x00569043
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060275EB RID: 161259 RVA: 0x0056AE4C File Offset: 0x0056904C
		public static IThrowFollowShooterInteractConfig GetRootAsIThrowFollowShooterInteractConfig(ByteBuffer _bb)
		{
			return IThrowFollowShooterInteractConfig.GetRootAsIThrowFollowShooterInteractConfig(_bb, default(IThrowFollowShooterInteractConfig));
		}

		// Token: 0x060275EC RID: 161260 RVA: 0x0056AE68 File Offset: 0x00569068
		public static IThrowFollowShooterInteractConfig GetRootAsIThrowFollowShooterInteractConfig(ByteBuffer _bb, IThrowFollowShooterInteractConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275ED RID: 161261 RVA: 0x0056AE85 File Offset: 0x00569085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275EE RID: 161262 RVA: 0x0056AE94 File Offset: 0x00569094
		public IThrowFollowShooterInteractConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE1D RID: 44573
		// (get) Token: 0x060275EF RID: 161263 RVA: 0x0056AEA4 File Offset: 0x005690A4
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060275F0 RID: 161264 RVA: 0x0056AEE4 File Offset: 0x005690E4
		public int MatchIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AE1E RID: 44574
		// (get) Token: 0x060275F1 RID: 161265 RVA: 0x0056AF24 File Offset: 0x00569124
		public int MatchIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060275F2 RID: 161266 RVA: 0x0056AF4F File Offset: 0x0056914F
		public Span<int> GetMatchIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060275F3 RID: 161267 RVA: 0x0056AF5E File Offset: 0x0056915E
		public int[] GetMatchIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700AE1F RID: 44575
		// (get) Token: 0x060275F4 RID: 161268 RVA: 0x0056AF6C File Offset: 0x0056916C
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060275F5 RID: 161269 RVA: 0x0056AFCC File Offset: 0x005691CC
		public IConditionAction? ArrivedConditionActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE20 RID: 44576
		// (get) Token: 0x060275F6 RID: 161270 RVA: 0x0056B030 File Offset: 0x00569230
		public int ArrivedConditionActionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060275F7 RID: 161271 RVA: 0x0056B05C File Offset: 0x0056925C
		public IConditionAction? LeavedConditionActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE21 RID: 44577
		// (get) Token: 0x060275F8 RID: 161272 RVA: 0x0056B0C0 File Offset: 0x005692C0
		public int LeavedConditionActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AE22 RID: 44578
		// (get) Token: 0x060275F9 RID: 161273 RVA: 0x0056B0EC File Offset: 0x005692EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060275FA RID: 161274 RVA: 0x0056B129 File Offset: 0x00569329
		public static Offset<IThrowFollowShooterInteractConfig> CreateIThrowFollowShooterInteractConfig(FlatBufferBuilder builder, float Radius = 0f, VectorOffset MatchIdsOffset = default(VectorOffset), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), VectorOffset ArrivedConditionActionsOffset = default(VectorOffset), VectorOffset LeavedConditionActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IThrowFollowShooterInteractConfig.AddLeavedConditionActions(builder, LeavedConditionActionsOffset);
			IThrowFollowShooterInteractConfig.AddArrivedConditionActions(builder, ArrivedConditionActionsOffset);
			IThrowFollowShooterInteractConfig.AddOffset(builder, OffsetOffset);
			IThrowFollowShooterInteractConfig.AddMatchIds(builder, MatchIdsOffset);
			IThrowFollowShooterInteractConfig.AddRadius(builder, Radius);
			IThrowFollowShooterInteractConfig.AddNullMask(builder, NullMask);
			return IThrowFollowShooterInteractConfig.EndIThrowFollowShooterInteractConfig(builder);
		}

		// Token: 0x060275FB RID: 161275 RVA: 0x0056B165 File Offset: 0x00569365
		public static void StartIThrowFollowShooterInteractConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060275FC RID: 161276 RVA: 0x0056B16E File Offset: 0x0056936E
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x060275FD RID: 161277 RVA: 0x0056B181 File Offset: 0x00569381
		public static void AddMatchIds(FlatBufferBuilder builder, VectorOffset matchIdsOffset)
		{
			builder.AddOffset(1, matchIdsOffset.Value, 0);
		}

		// Token: 0x060275FE RID: 161278 RVA: 0x0056B194 File Offset: 0x00569394
		public static VectorOffset CreateMatchIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060275FF RID: 161279 RVA: 0x0056B1CB File Offset: 0x005693CB
		public static VectorOffset CreateMatchIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027600 RID: 161280 RVA: 0x0056B1E5 File Offset: 0x005693E5
		public static VectorOffset CreateMatchIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027601 RID: 161281 RVA: 0x0056B203 File Offset: 0x00569403
		public static VectorOffset CreateMatchIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027602 RID: 161282 RVA: 0x0056B21C File Offset: 0x0056941C
		public static void StartMatchIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027603 RID: 161283 RVA: 0x0056B227 File Offset: 0x00569427
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06027604 RID: 161284 RVA: 0x0056B237 File Offset: 0x00569437
		public static void AddArrivedConditionActions(FlatBufferBuilder builder, VectorOffset arrivedConditionActionsOffset)
		{
			builder.AddOffset(3, arrivedConditionActionsOffset.Value, 0);
		}

		// Token: 0x06027605 RID: 161285 RVA: 0x0056B248 File Offset: 0x00569448
		public static VectorOffset CreateArrivedConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027606 RID: 161286 RVA: 0x0056B288 File Offset: 0x00569488
		public static VectorOffset CreateArrivedConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027607 RID: 161287 RVA: 0x0056B2A2 File Offset: 0x005694A2
		public static VectorOffset CreateArrivedConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027608 RID: 161288 RVA: 0x0056B2C0 File Offset: 0x005694C0
		public static VectorOffset CreateArrivedConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027609 RID: 161289 RVA: 0x0056B2D9 File Offset: 0x005694D9
		public static void StartArrivedConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602760A RID: 161290 RVA: 0x0056B2E4 File Offset: 0x005694E4
		public static void AddLeavedConditionActions(FlatBufferBuilder builder, VectorOffset leavedConditionActionsOffset)
		{
			builder.AddOffset(4, leavedConditionActionsOffset.Value, 0);
		}

		// Token: 0x0602760B RID: 161291 RVA: 0x0056B2F4 File Offset: 0x005694F4
		public static VectorOffset CreateLeavedConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602760C RID: 161292 RVA: 0x0056B334 File Offset: 0x00569534
		public static VectorOffset CreateLeavedConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602760D RID: 161293 RVA: 0x0056B34E File Offset: 0x0056954E
		public static VectorOffset CreateLeavedConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602760E RID: 161294 RVA: 0x0056B36C File Offset: 0x0056956C
		public static VectorOffset CreateLeavedConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602760F RID: 161295 RVA: 0x0056B385 File Offset: 0x00569585
		public static void StartLeavedConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027610 RID: 161296 RVA: 0x0056B390 File Offset: 0x00569590
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06027611 RID: 161297 RVA: 0x0056B39B File Offset: 0x0056959B
		public static Offset<IThrowFollowShooterInteractConfig> EndIThrowFollowShooterInteractConfig(FlatBufferBuilder builder)
		{
			return new Offset<IThrowFollowShooterInteractConfig>(builder.EndTable());
		}

		// Token: 0x06027612 RID: 161298 RVA: 0x0056B3A8 File Offset: 0x005695A8
		public IThrowFollowShooterInteractConfigT UnPack()
		{
			IThrowFollowShooterInteractConfigT throwFollowShooterInteractConfigT = new IThrowFollowShooterInteractConfigT();
			this.UnPackTo(throwFollowShooterInteractConfigT);
			return throwFollowShooterInteractConfigT;
		}

		// Token: 0x06027613 RID: 161299 RVA: 0x0056B3C4 File Offset: 0x005695C4
		public void UnPackTo(IThrowFollowShooterInteractConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.MatchIds = new List<int>();
			for (int i = 0; i < this.MatchIdsLength; i++)
			{
				_o.MatchIds.Add(this.MatchIds(i));
			}
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ArrivedConditionActions = new List<IConditionActionT>();
			for (int j = 0; j < this.ArrivedConditionActionsLength; j++)
			{
				_o.ArrivedConditionActions.Add((this.ArrivedConditionActions(j) != null) ? this.ArrivedConditionActions(j).Value.UnPack() : null);
			}
			_o.LeavedConditionActions = new List<IConditionActionT>();
			for (int k = 0; k < this.LeavedConditionActionsLength; k++)
			{
				_o.LeavedConditionActions.Add((this.LeavedConditionActions(k) != null) ? this.LeavedConditionActions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027614 RID: 161300 RVA: 0x0056B4F8 File Offset: 0x005696F8
		public static Offset<IThrowFollowShooterInteractConfig> Pack(FlatBufferBuilder builder, IThrowFollowShooterInteractConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowFollowShooterInteractConfig>);
			}
			VectorOffset matchIdsOffset = default(VectorOffset);
			if (_o.MatchIds != null)
			{
				int[] data = _o.MatchIds.ToArray();
				matchIdsOffset = IThrowFollowShooterInteractConfig.CreateMatchIdsVector(builder, data);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			VectorOffset arrivedConditionActionsOffset = default(VectorOffset);
			if (_o.ArrivedConditionActions != null)
			{
				Offset<IConditionAction>[] array = new Offset<IConditionAction>[_o.ArrivedConditionActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionAction.Pack(builder, _o.ArrivedConditionActions[i]);
				}
				arrivedConditionActionsOffset = IThrowFollowShooterInteractConfig.CreateArrivedConditionActionsVector(builder, array);
			}
			VectorOffset leavedConditionActionsOffset = default(VectorOffset);
			if (_o.LeavedConditionActions != null)
			{
				Offset<IConditionAction>[] array2 = new Offset<IConditionAction>[_o.LeavedConditionActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionAction.Pack(builder, _o.LeavedConditionActions[j]);
				}
				leavedConditionActionsOffset = IThrowFollowShooterInteractConfig.CreateLeavedConditionActionsVector(builder, array2);
			}
			return IThrowFollowShooterInteractConfig.CreateIThrowFollowShooterInteractConfig(builder, _o.Radius, matchIdsOffset, offsetOffset, arrivedConditionActionsOffset, leavedConditionActionsOffset, _o.NullMask);
		}

		// Token: 0x0400F0F2 RID: 61682
		private Table __p;
	}
}
