using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200487D RID: 18557
	public struct ISubWpData : IFlatbufferObject
	{
		// Token: 0x17008133 RID: 33075
		// (get) Token: 0x0601B71B RID: 112411 RVA: 0x003E26A3 File Offset: 0x003E08A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B71C RID: 112412 RVA: 0x003E26B0 File Offset: 0x003E08B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B71D RID: 112413 RVA: 0x003E26B8 File Offset: 0x003E08B8
		public static ISubWpData GetRootAsISubWpData(ByteBuffer _bb)
		{
			return ISubWpData.GetRootAsISubWpData(_bb, default(ISubWpData));
		}

		// Token: 0x0601B71E RID: 112414 RVA: 0x003E26D4 File Offset: 0x003E08D4
		public static ISubWpData GetRootAsISubWpData(ByteBuffer _bb, ISubWpData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B71F RID: 112415 RVA: 0x003E26F1 File Offset: 0x003E08F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B720 RID: 112416 RVA: 0x003E2700 File Offset: 0x003E0900
		public ISubWpData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008134 RID: 33076
		// (get) Token: 0x0601B721 RID: 112417 RVA: 0x003E2710 File Offset: 0x003E0910
		public int SubWpId
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

		// Token: 0x17008135 RID: 33077
		// (get) Token: 0x0601B722 RID: 112418 RVA: 0x003E274C File Offset: 0x003E094C
		public IVectorInfo? Location
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

		// Token: 0x0601B723 RID: 112419 RVA: 0x003E27A9 File Offset: 0x003E09A9
		public static Offset<ISubWpData> CreateISubWpData(FlatBufferBuilder builder, int SubWpId = 0, Offset<IVectorInfo> LocationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ISubWpData.AddLocation(builder, LocationOffset);
			ISubWpData.AddSubWpId(builder, SubWpId);
			return ISubWpData.EndISubWpData(builder);
		}

		// Token: 0x0601B724 RID: 112420 RVA: 0x003E27C6 File Offset: 0x003E09C6
		public static void StartISubWpData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B725 RID: 112421 RVA: 0x003E27CF File Offset: 0x003E09CF
		public static void AddSubWpId(FlatBufferBuilder builder, int subWpId)
		{
			builder.AddInt(0, subWpId, 0);
		}

		// Token: 0x0601B726 RID: 112422 RVA: 0x003E27DA File Offset: 0x003E09DA
		public static void AddLocation(FlatBufferBuilder builder, Offset<IVectorInfo> locationOffset)
		{
			builder.AddOffset(1, locationOffset.Value, 0);
		}

		// Token: 0x0601B727 RID: 112423 RVA: 0x003E27EA File Offset: 0x003E09EA
		public static Offset<ISubWpData> EndISubWpData(FlatBufferBuilder builder)
		{
			return new Offset<ISubWpData>(builder.EndTable());
		}

		// Token: 0x0601B728 RID: 112424 RVA: 0x003E27F8 File Offset: 0x003E09F8
		public ISubWpDataT UnPack()
		{
			ISubWpDataT subWpDataT = new ISubWpDataT();
			this.UnPackTo(subWpDataT);
			return subWpDataT;
		}

		// Token: 0x0601B729 RID: 112425 RVA: 0x003E2814 File Offset: 0x003E0A14
		public void UnPackTo(ISubWpDataT _o)
		{
			_o.SubWpId = this.SubWpId;
			_o.Location = ((this.Location != null) ? this.Location.Value.UnPack() : null);
		}

		// Token: 0x0601B72A RID: 112426 RVA: 0x003E285C File Offset: 0x003E0A5C
		public static Offset<ISubWpData> Pack(FlatBufferBuilder builder, ISubWpDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubWpData>);
			}
			Offset<IVectorInfo> locationOffset = (_o.Location == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Location);
			return ISubWpData.CreateISubWpData(builder, _o.SubWpId, locationOffset);
		}

		// Token: 0x0400CD9E RID: 52638
		private Table __p;
	}
}
