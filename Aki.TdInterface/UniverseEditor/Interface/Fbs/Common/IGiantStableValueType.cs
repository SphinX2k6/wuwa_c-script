using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006419 RID: 25625
	public struct IGiantStableValueType : IFlatbufferObject
	{
		// Token: 0x1700BD46 RID: 48454
		// (get) Token: 0x0602B896 RID: 178326 RVA: 0x005EDCF4 File Offset: 0x005EBEF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B897 RID: 178327 RVA: 0x005EDD01 File Offset: 0x005EBF01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B898 RID: 178328 RVA: 0x005EDD08 File Offset: 0x005EBF08
		public static IGiantStableValueType GetRootAsIGiantStableValueType(ByteBuffer _bb)
		{
			return IGiantStableValueType.GetRootAsIGiantStableValueType(_bb, default(IGiantStableValueType));
		}

		// Token: 0x0602B899 RID: 178329 RVA: 0x005EDD24 File Offset: 0x005EBF24
		public static IGiantStableValueType GetRootAsIGiantStableValueType(ByteBuffer _bb, IGiantStableValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B89A RID: 178330 RVA: 0x005EDD41 File Offset: 0x005EBF41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B89B RID: 178331 RVA: 0x005EDD50 File Offset: 0x005EBF50
		public IGiantStableValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD47 RID: 48455
		// (get) Token: 0x0602B89C RID: 178332 RVA: 0x005EDD60 File Offset: 0x005EBF60
		public EGiantStableValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueType.Region;
				}
				return (EGiantStableValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B89D RID: 178333 RVA: 0x005EDD9C File Offset: 0x005EBF9C
		public static Offset<IGiantStableValueType> CreateIGiantStableValueType(FlatBufferBuilder builder, EGiantStableValueType Type = EGiantStableValueType.Region)
		{
			builder.StartTable(1);
			IGiantStableValueType.AddType(builder, Type);
			return IGiantStableValueType.EndIGiantStableValueType(builder);
		}

		// Token: 0x0602B89E RID: 178334 RVA: 0x005EDDB2 File Offset: 0x005EBFB2
		public static void StartIGiantStableValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B89F RID: 178335 RVA: 0x005EDDBB File Offset: 0x005EBFBB
		public static void AddType(FlatBufferBuilder builder, EGiantStableValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B8A0 RID: 178336 RVA: 0x005EDDC6 File Offset: 0x005EBFC6
		public static Offset<IGiantStableValueType> EndIGiantStableValueType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueType>(builder.EndTable());
		}

		// Token: 0x0602B8A1 RID: 178337 RVA: 0x005EDDD4 File Offset: 0x005EBFD4
		public IGiantStableValueTypeT UnPack()
		{
			IGiantStableValueTypeT giantStableValueTypeT = new IGiantStableValueTypeT();
			this.UnPackTo(giantStableValueTypeT);
			return giantStableValueTypeT;
		}

		// Token: 0x0602B8A2 RID: 178338 RVA: 0x005EDDEF File Offset: 0x005EBFEF
		public void UnPackTo(IGiantStableValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B8A3 RID: 178339 RVA: 0x005EDE00 File Offset: 0x005EC000
		public static Offset<IGiantStableValueType> Pack(FlatBufferBuilder builder, IGiantStableValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueType>);
			}
			return IGiantStableValueType.CreateIGiantStableValueType(builder, _o.Type);
		}

		// Token: 0x0401051E RID: 66846
		private Table __p;
	}
}
