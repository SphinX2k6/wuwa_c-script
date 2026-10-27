using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006711 RID: 26385
	public struct IExecResurrection : IFlatbufferObject
	{
		// Token: 0x1700C400 RID: 50176
		// (get) Token: 0x0602DE43 RID: 187971 RVA: 0x006467C8 File Offset: 0x006449C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE44 RID: 187972 RVA: 0x006467D5 File Offset: 0x006449D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE45 RID: 187973 RVA: 0x006467DC File Offset: 0x006449DC
		public static IExecResurrection GetRootAsIExecResurrection(ByteBuffer _bb)
		{
			return IExecResurrection.GetRootAsIExecResurrection(_bb, default(IExecResurrection));
		}

		// Token: 0x0602DE46 RID: 187974 RVA: 0x006467F8 File Offset: 0x006449F8
		public static IExecResurrection GetRootAsIExecResurrection(ByteBuffer _bb, IExecResurrection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE47 RID: 187975 RVA: 0x00646815 File Offset: 0x00644A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE48 RID: 187976 RVA: 0x00646824 File Offset: 0x00644A24
		public IExecResurrection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C401 RID: 50177
		// (get) Token: 0x0602DE49 RID: 187977 RVA: 0x00646834 File Offset: 0x00644A34
		public int ReviveId
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

		// Token: 0x0602DE4A RID: 187978 RVA: 0x00646870 File Offset: 0x00644A70
		public static Offset<IExecResurrection> CreateIExecResurrection(FlatBufferBuilder builder, int ReviveId = 0)
		{
			builder.StartTable(1);
			IExecResurrection.AddReviveId(builder, ReviveId);
			return IExecResurrection.EndIExecResurrection(builder);
		}

		// Token: 0x0602DE4B RID: 187979 RVA: 0x00646886 File Offset: 0x00644A86
		public static void StartIExecResurrection(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DE4C RID: 187980 RVA: 0x0064688F File Offset: 0x00644A8F
		public static void AddReviveId(FlatBufferBuilder builder, int reviveId)
		{
			builder.AddInt(0, reviveId, 0);
		}

		// Token: 0x0602DE4D RID: 187981 RVA: 0x0064689A File Offset: 0x00644A9A
		public static Offset<IExecResurrection> EndIExecResurrection(FlatBufferBuilder builder)
		{
			return new Offset<IExecResurrection>(builder.EndTable());
		}

		// Token: 0x0602DE4E RID: 187982 RVA: 0x006468A8 File Offset: 0x00644AA8
		public IExecResurrectionT UnPack()
		{
			IExecResurrectionT execResurrectionT = new IExecResurrectionT();
			this.UnPackTo(execResurrectionT);
			return execResurrectionT;
		}

		// Token: 0x0602DE4F RID: 187983 RVA: 0x006468C3 File Offset: 0x00644AC3
		public void UnPackTo(IExecResurrectionT _o)
		{
			_o.ReviveId = this.ReviveId;
		}

		// Token: 0x0602DE50 RID: 187984 RVA: 0x006468D4 File Offset: 0x00644AD4
		public static Offset<IExecResurrection> Pack(FlatBufferBuilder builder, IExecResurrectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecResurrection>);
			}
			return IExecResurrection.CreateIExecResurrection(builder, _o.ReviveId);
		}

		// Token: 0x04010DF8 RID: 69112
		private Table __p;
	}
}
