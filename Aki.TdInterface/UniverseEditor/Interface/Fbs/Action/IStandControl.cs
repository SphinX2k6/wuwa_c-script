using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200797D RID: 31101
	public struct IStandControl : IFlatbufferObject
	{
		// Token: 0x1700E40D RID: 58381
		// (get) Token: 0x06036C64 RID: 224356 RVA: 0x00753B09 File Offset: 0x00751D09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036C65 RID: 224357 RVA: 0x00753B16 File Offset: 0x00751D16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036C66 RID: 224358 RVA: 0x00753B20 File Offset: 0x00751D20
		public static IStandControl GetRootAsIStandControl(ByteBuffer _bb)
		{
			return IStandControl.GetRootAsIStandControl(_bb, default(IStandControl));
		}

		// Token: 0x06036C67 RID: 224359 RVA: 0x00753B3C File Offset: 0x00751D3C
		public static IStandControl GetRootAsIStandControl(ByteBuffer _bb, IStandControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036C68 RID: 224360 RVA: 0x00753B59 File Offset: 0x00751D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036C69 RID: 224361 RVA: 0x00753B68 File Offset: 0x00751D68
		public IStandControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E40E RID: 58382
		// (get) Token: 0x06036C6A RID: 224362 RVA: 0x00753B78 File Offset: 0x00751D78
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036C6B RID: 224363 RVA: 0x00753BB4 File Offset: 0x00751DB4
		public static Offset<IStandControl> CreateIStandControl(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IStandControl.AddType(builder, Type);
			return IStandControl.EndIStandControl(builder);
		}

		// Token: 0x06036C6C RID: 224364 RVA: 0x00753BCA File Offset: 0x00751DCA
		public static void StartIStandControl(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036C6D RID: 224365 RVA: 0x00753BD3 File Offset: 0x00751DD3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036C6E RID: 224366 RVA: 0x00753BDE File Offset: 0x00751DDE
		public static Offset<IStandControl> EndIStandControl(FlatBufferBuilder builder)
		{
			return new Offset<IStandControl>(builder.EndTable());
		}

		// Token: 0x06036C6F RID: 224367 RVA: 0x00753BEC File Offset: 0x00751DEC
		public IStandControlT UnPack()
		{
			IStandControlT standControlT = new IStandControlT();
			this.UnPackTo(standControlT);
			return standControlT;
		}

		// Token: 0x06036C70 RID: 224368 RVA: 0x00753C07 File Offset: 0x00751E07
		public void UnPackTo(IStandControlT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036C71 RID: 224369 RVA: 0x00753C18 File Offset: 0x00751E18
		public static Offset<IStandControl> Pack(FlatBufferBuilder builder, IStandControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStandControl>);
			}
			return IStandControl.CreateIStandControl(builder, _o.Type);
		}

		// Token: 0x04012C72 RID: 76914
		private Table __p;
	}
}
