using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004415 RID: 17429
	public struct ISubWpData : IFlatbufferObject
	{
		// Token: 0x17007AF4 RID: 31476
		// (get) Token: 0x06019F4A RID: 106314 RVA: 0x003B6497 File Offset: 0x003B4697
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F4B RID: 106315 RVA: 0x003B64A4 File Offset: 0x003B46A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F4C RID: 106316 RVA: 0x003B64AC File Offset: 0x003B46AC
		public static ISubWpData GetRootAsISubWpData(ByteBuffer _bb)
		{
			return ISubWpData.GetRootAsISubWpData(_bb, default(ISubWpData));
		}

		// Token: 0x06019F4D RID: 106317 RVA: 0x003B64C8 File Offset: 0x003B46C8
		public static ISubWpData GetRootAsISubWpData(ByteBuffer _bb, ISubWpData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F4E RID: 106318 RVA: 0x003B64E5 File Offset: 0x003B46E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F4F RID: 106319 RVA: 0x003B64F4 File Offset: 0x003B46F4
		public ISubWpData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AF5 RID: 31477
		// (get) Token: 0x06019F50 RID: 106320 RVA: 0x003B6504 File Offset: 0x003B4704
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

		// Token: 0x17007AF6 RID: 31478
		// (get) Token: 0x06019F51 RID: 106321 RVA: 0x003B6540 File Offset: 0x003B4740
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

		// Token: 0x06019F52 RID: 106322 RVA: 0x003B659D File Offset: 0x003B479D
		public static Offset<ISubWpData> CreateISubWpData(FlatBufferBuilder builder, int SubWpId = 0, Offset<IVectorInfo> LocationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ISubWpData.AddLocation(builder, LocationOffset);
			ISubWpData.AddSubWpId(builder, SubWpId);
			return ISubWpData.EndISubWpData(builder);
		}

		// Token: 0x06019F53 RID: 106323 RVA: 0x003B65BA File Offset: 0x003B47BA
		public static void StartISubWpData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019F54 RID: 106324 RVA: 0x003B65C3 File Offset: 0x003B47C3
		public static void AddSubWpId(FlatBufferBuilder builder, int subWpId)
		{
			builder.AddInt(0, subWpId, 0);
		}

		// Token: 0x06019F55 RID: 106325 RVA: 0x003B65CE File Offset: 0x003B47CE
		public static void AddLocation(FlatBufferBuilder builder, Offset<IVectorInfo> locationOffset)
		{
			builder.AddOffset(1, locationOffset.Value, 0);
		}

		// Token: 0x06019F56 RID: 106326 RVA: 0x003B65DE File Offset: 0x003B47DE
		public static Offset<ISubWpData> EndISubWpData(FlatBufferBuilder builder)
		{
			return new Offset<ISubWpData>(builder.EndTable());
		}

		// Token: 0x06019F57 RID: 106327 RVA: 0x003B65EC File Offset: 0x003B47EC
		public ISubWpDataT UnPack()
		{
			ISubWpDataT subWpDataT = new ISubWpDataT();
			this.UnPackTo(subWpDataT);
			return subWpDataT;
		}

		// Token: 0x06019F58 RID: 106328 RVA: 0x003B6608 File Offset: 0x003B4808
		public void UnPackTo(ISubWpDataT _o)
		{
			_o.SubWpId = this.SubWpId;
			_o.Location = ((this.Location != null) ? this.Location.Value.UnPack() : null);
		}

		// Token: 0x06019F59 RID: 106329 RVA: 0x003B6650 File Offset: 0x003B4850
		public static Offset<ISubWpData> Pack(FlatBufferBuilder builder, ISubWpDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubWpData>);
			}
			Offset<IVectorInfo> locationOffset = (_o.Location == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Location);
			return ISubWpData.CreateISubWpData(builder, _o.SubWpId, locationOffset);
		}

		// Token: 0x0400C371 RID: 50033
		private Table __p;
	}
}
