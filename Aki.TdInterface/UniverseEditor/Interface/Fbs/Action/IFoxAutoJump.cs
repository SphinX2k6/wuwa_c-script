using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006858 RID: 26712
	public struct IFoxAutoJump : IFlatbufferObject
	{
		// Token: 0x1700C664 RID: 50788
		// (get) Token: 0x0602E92F RID: 190767 RVA: 0x0065A7B1 File Offset: 0x006589B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E930 RID: 190768 RVA: 0x0065A7BE File Offset: 0x006589BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E931 RID: 190769 RVA: 0x0065A7C8 File Offset: 0x006589C8
		public static IFoxAutoJump GetRootAsIFoxAutoJump(ByteBuffer _bb)
		{
			return IFoxAutoJump.GetRootAsIFoxAutoJump(_bb, default(IFoxAutoJump));
		}

		// Token: 0x0602E932 RID: 190770 RVA: 0x0065A7E4 File Offset: 0x006589E4
		public static IFoxAutoJump GetRootAsIFoxAutoJump(ByteBuffer _bb, IFoxAutoJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E933 RID: 190771 RVA: 0x0065A801 File Offset: 0x00658A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E934 RID: 190772 RVA: 0x0065A810 File Offset: 0x00658A10
		public IFoxAutoJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C665 RID: 50789
		// (get) Token: 0x0602E935 RID: 190773 RVA: 0x0065A820 File Offset: 0x00658A20
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

		// Token: 0x1700C666 RID: 50790
		// (get) Token: 0x0602E936 RID: 190774 RVA: 0x0065A85C File Offset: 0x00658A5C
		public IVectorInfo? LandPosition
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

		// Token: 0x0602E937 RID: 190775 RVA: 0x0065A8B9 File Offset: 0x00658AB9
		public static Offset<IFoxAutoJump> CreateIFoxAutoJump(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<IVectorInfo> LandPositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IFoxAutoJump.AddLandPosition(builder, LandPositionOffset);
			IFoxAutoJump.AddType(builder, Type);
			return IFoxAutoJump.EndIFoxAutoJump(builder);
		}

		// Token: 0x0602E938 RID: 190776 RVA: 0x0065A8D6 File Offset: 0x00658AD6
		public static void StartIFoxAutoJump(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E939 RID: 190777 RVA: 0x0065A8DF File Offset: 0x00658ADF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E93A RID: 190778 RVA: 0x0065A8EA File Offset: 0x00658AEA
		public static void AddLandPosition(FlatBufferBuilder builder, Offset<IVectorInfo> landPositionOffset)
		{
			builder.AddOffset(1, landPositionOffset.Value, 0);
		}

		// Token: 0x0602E93B RID: 190779 RVA: 0x0065A8FA File Offset: 0x00658AFA
		public static Offset<IFoxAutoJump> EndIFoxAutoJump(FlatBufferBuilder builder)
		{
			return new Offset<IFoxAutoJump>(builder.EndTable());
		}

		// Token: 0x0602E93C RID: 190780 RVA: 0x0065A908 File Offset: 0x00658B08
		public IFoxAutoJumpT UnPack()
		{
			IFoxAutoJumpT foxAutoJumpT = new IFoxAutoJumpT();
			this.UnPackTo(foxAutoJumpT);
			return foxAutoJumpT;
		}

		// Token: 0x0602E93D RID: 190781 RVA: 0x0065A924 File Offset: 0x00658B24
		public void UnPackTo(IFoxAutoJumpT _o)
		{
			_o.Type = this.Type;
			_o.LandPosition = ((this.LandPosition != null) ? this.LandPosition.Value.UnPack() : null);
		}

		// Token: 0x0602E93E RID: 190782 RVA: 0x0065A96C File Offset: 0x00658B6C
		public static Offset<IFoxAutoJump> Pack(FlatBufferBuilder builder, IFoxAutoJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxAutoJump>);
			}
			Offset<IVectorInfo> landPositionOffset = (_o.LandPosition == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LandPosition);
			return IFoxAutoJump.CreateIFoxAutoJump(builder, _o.Type, landPositionOffset);
		}

		// Token: 0x04010FA3 RID: 69539
		private Table __p;
	}
}
