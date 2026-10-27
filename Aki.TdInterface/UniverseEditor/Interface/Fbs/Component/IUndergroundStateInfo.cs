using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFF RID: 23295
	public struct IUndergroundStateInfo : IFlatbufferObject
	{
		// Token: 0x1700AFC0 RID: 44992
		// (get) Token: 0x06027C60 RID: 162912 RVA: 0x00578807 File Offset: 0x00576A07
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C61 RID: 162913 RVA: 0x00578814 File Offset: 0x00576A14
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C62 RID: 162914 RVA: 0x0057881C File Offset: 0x00576A1C
		public static IUndergroundStateInfo GetRootAsIUndergroundStateInfo(ByteBuffer _bb)
		{
			return IUndergroundStateInfo.GetRootAsIUndergroundStateInfo(_bb, default(IUndergroundStateInfo));
		}

		// Token: 0x06027C63 RID: 162915 RVA: 0x00578838 File Offset: 0x00576A38
		public static IUndergroundStateInfo GetRootAsIUndergroundStateInfo(ByteBuffer _bb, IUndergroundStateInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C64 RID: 162916 RVA: 0x00578855 File Offset: 0x00576A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C65 RID: 162917 RVA: 0x00578864 File Offset: 0x00576A64
		public IUndergroundStateInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFC1 RID: 44993
		// (get) Token: 0x06027C66 RID: 162918 RVA: 0x00578874 File Offset: 0x00576A74
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFC2 RID: 44994
		// (get) Token: 0x06027C67 RID: 162919 RVA: 0x005788B0 File Offset: 0x00576AB0
		public IVectorInfo? RestartPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027C68 RID: 162920 RVA: 0x0057890D File Offset: 0x00576B0D
		public static Offset<IUndergroundStateInfo> CreateIUndergroundStateInfo(FlatBufferBuilder builder, int StateId = 0, Offset<IVectorInfo> RestartPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IUndergroundStateInfo.AddRestartPos(builder, RestartPosOffset);
			IUndergroundStateInfo.AddStateId(builder, StateId);
			return IUndergroundStateInfo.EndIUndergroundStateInfo(builder);
		}

		// Token: 0x06027C69 RID: 162921 RVA: 0x0057892A File Offset: 0x00576B2A
		public static void StartIUndergroundStateInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027C6A RID: 162922 RVA: 0x00578933 File Offset: 0x00576B33
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x06027C6B RID: 162923 RVA: 0x0057893E File Offset: 0x00576B3E
		public static void AddRestartPos(FlatBufferBuilder builder, Offset<IVectorInfo> restartPosOffset)
		{
			builder.AddOffset(1, restartPosOffset.Value, 0);
		}

		// Token: 0x06027C6C RID: 162924 RVA: 0x0057894E File Offset: 0x00576B4E
		public static Offset<IUndergroundStateInfo> EndIUndergroundStateInfo(FlatBufferBuilder builder)
		{
			return new Offset<IUndergroundStateInfo>(builder.EndTable());
		}

		// Token: 0x06027C6D RID: 162925 RVA: 0x0057895C File Offset: 0x00576B5C
		public IUndergroundStateInfoT UnPack()
		{
			IUndergroundStateInfoT undergroundStateInfoT = new IUndergroundStateInfoT();
			this.UnPackTo(undergroundStateInfoT);
			return undergroundStateInfoT;
		}

		// Token: 0x06027C6E RID: 162926 RVA: 0x00578978 File Offset: 0x00576B78
		public void UnPackTo(IUndergroundStateInfoT _o)
		{
			_o.StateId = this.StateId;
			_o.RestartPos = ((this.RestartPos != null) ? this.RestartPos.Value.UnPack() : null);
		}

		// Token: 0x06027C6F RID: 162927 RVA: 0x005789C0 File Offset: 0x00576BC0
		public static Offset<IUndergroundStateInfo> Pack(FlatBufferBuilder builder, IUndergroundStateInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUndergroundStateInfo>);
			}
			Offset<IVectorInfo> restartPosOffset = (_o.RestartPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RestartPos);
			return IUndergroundStateInfo.CreateIUndergroundStateInfo(builder, _o.StateId, restartPosOffset);
		}

		// Token: 0x0400F202 RID: 61954
		private Table __p;
	}
}
