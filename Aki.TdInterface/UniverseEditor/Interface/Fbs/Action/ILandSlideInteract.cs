using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DE RID: 27102
	public struct ILandSlideInteract : IFlatbufferObject
	{
		// Token: 0x1700C918 RID: 51480
		// (get) Token: 0x0602F605 RID: 194053 RVA: 0x006737A5 File Offset: 0x006719A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F606 RID: 194054 RVA: 0x006737B2 File Offset: 0x006719B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F607 RID: 194055 RVA: 0x006737BC File Offset: 0x006719BC
		public static ILandSlideInteract GetRootAsILandSlideInteract(ByteBuffer _bb)
		{
			return ILandSlideInteract.GetRootAsILandSlideInteract(_bb, default(ILandSlideInteract));
		}

		// Token: 0x0602F608 RID: 194056 RVA: 0x006737D8 File Offset: 0x006719D8
		public static ILandSlideInteract GetRootAsILandSlideInteract(ByteBuffer _bb, ILandSlideInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F609 RID: 194057 RVA: 0x006737F5 File Offset: 0x006719F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F60A RID: 194058 RVA: 0x00673804 File Offset: 0x00671A04
		public ILandSlideInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C919 RID: 51481
		// (get) Token: 0x0602F60B RID: 194059 RVA: 0x00673814 File Offset: 0x00671A14
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

		// Token: 0x0602F60C RID: 194060 RVA: 0x00673850 File Offset: 0x00671A50
		public static Offset<ILandSlideInteract> CreateILandSlideInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ILandSlideInteract.AddType(builder, Type);
			return ILandSlideInteract.EndILandSlideInteract(builder);
		}

		// Token: 0x0602F60D RID: 194061 RVA: 0x00673866 File Offset: 0x00671A66
		public static void StartILandSlideInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F60E RID: 194062 RVA: 0x0067386F File Offset: 0x00671A6F
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F60F RID: 194063 RVA: 0x0067387A File Offset: 0x00671A7A
		public static Offset<ILandSlideInteract> EndILandSlideInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILandSlideInteract>(builder.EndTable());
		}

		// Token: 0x0602F610 RID: 194064 RVA: 0x00673888 File Offset: 0x00671A88
		public ILandSlideInteractT UnPack()
		{
			ILandSlideInteractT landSlideInteractT = new ILandSlideInteractT();
			this.UnPackTo(landSlideInteractT);
			return landSlideInteractT;
		}

		// Token: 0x0602F611 RID: 194065 RVA: 0x006738A3 File Offset: 0x00671AA3
		public void UnPackTo(ILandSlideInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F612 RID: 194066 RVA: 0x006738B4 File Offset: 0x00671AB4
		public static Offset<ILandSlideInteract> Pack(FlatBufferBuilder builder, ILandSlideInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILandSlideInteract>);
			}
			return ILandSlideInteract.CreateILandSlideInteract(builder, _o.Type);
		}

		// Token: 0x0401119C RID: 70044
		private Table __p;
	}
}
