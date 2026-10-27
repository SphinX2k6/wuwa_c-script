using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1A RID: 27162
	public struct ILimitPlayerMouse : IFlatbufferObject
	{
		// Token: 0x1700C97D RID: 51581
		// (get) Token: 0x0602F873 RID: 194675 RVA: 0x0067889D File Offset: 0x00676A9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F874 RID: 194676 RVA: 0x006788AA File Offset: 0x00676AAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F875 RID: 194677 RVA: 0x006788B4 File Offset: 0x00676AB4
		public static ILimitPlayerMouse GetRootAsILimitPlayerMouse(ByteBuffer _bb)
		{
			return ILimitPlayerMouse.GetRootAsILimitPlayerMouse(_bb, default(ILimitPlayerMouse));
		}

		// Token: 0x0602F876 RID: 194678 RVA: 0x006788D0 File Offset: 0x00676AD0
		public static ILimitPlayerMouse GetRootAsILimitPlayerMouse(ByteBuffer _bb, ILimitPlayerMouse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F877 RID: 194679 RVA: 0x006788ED File Offset: 0x00676AED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F878 RID: 194680 RVA: 0x006788FC File Offset: 0x00676AFC
		public ILimitPlayerMouse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C97E RID: 51582
		// (get) Token: 0x0602F879 RID: 194681 RVA: 0x0067890C File Offset: 0x00676B0C
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F87A RID: 194682 RVA: 0x00678948 File Offset: 0x00676B48
		public static Offset<ILimitPlayerMouse> CreateILimitPlayerMouse(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerMouse.AddType(builder, Type);
			return ILimitPlayerMouse.EndILimitPlayerMouse(builder);
		}

		// Token: 0x0602F87B RID: 194683 RVA: 0x0067895E File Offset: 0x00676B5E
		public static void StartILimitPlayerMouse(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F87C RID: 194684 RVA: 0x00678967 File Offset: 0x00676B67
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F87D RID: 194685 RVA: 0x00678972 File Offset: 0x00676B72
		public static Offset<ILimitPlayerMouse> EndILimitPlayerMouse(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerMouse>(builder.EndTable());
		}

		// Token: 0x0602F87E RID: 194686 RVA: 0x00678980 File Offset: 0x00676B80
		public ILimitPlayerMouseT UnPack()
		{
			ILimitPlayerMouseT limitPlayerMouseT = new ILimitPlayerMouseT();
			this.UnPackTo(limitPlayerMouseT);
			return limitPlayerMouseT;
		}

		// Token: 0x0602F87F RID: 194687 RVA: 0x0067899B File Offset: 0x00676B9B
		public void UnPackTo(ILimitPlayerMouseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F880 RID: 194688 RVA: 0x006789AC File Offset: 0x00676BAC
		public static Offset<ILimitPlayerMouse> Pack(FlatBufferBuilder builder, ILimitPlayerMouseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerMouse>);
			}
			return ILimitPlayerMouse.CreateILimitPlayerMouse(builder, _o.Type);
		}

		// Token: 0x0401121F RID: 70175
		private Table __p;
	}
}
