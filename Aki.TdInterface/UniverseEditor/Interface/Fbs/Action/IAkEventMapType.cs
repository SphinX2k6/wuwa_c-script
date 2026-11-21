using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067ED RID: 26605
	public struct IAkEventMapType : IFlatbufferObject
	{
		// Token: 0x1700C3A2 RID: 50082
		// (get) Token: 0x0602D72F RID: 186159 RVA: 0x006393AA File Offset: 0x006375AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D730 RID: 186160 RVA: 0x006393B7 File Offset: 0x006375B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D731 RID: 186161 RVA: 0x006393C0 File Offset: 0x006375C0
		public static IAkEventMapType GetRootAsIAkEventMapType(ByteBuffer _bb)
		{
			return IAkEventMapType.GetRootAsIAkEventMapType(_bb, default(IAkEventMapType));
		}

		// Token: 0x0602D732 RID: 186162 RVA: 0x006393DC File Offset: 0x006375DC
		public static IAkEventMapType GetRootAsIAkEventMapType(ByteBuffer _bb, IAkEventMapType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D733 RID: 186163 RVA: 0x006393F9 File Offset: 0x006375F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D734 RID: 186164 RVA: 0x00639408 File Offset: 0x00637608
		public IAkEventMapType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3A3 RID: 50083
		// (get) Token: 0x0602D735 RID: 186165 RVA: 0x00639418 File Offset: 0x00637618
		public EAkEventMap Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventMap.PlayMapMusic;
				}
				return (EAkEventMap)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D736 RID: 186166 RVA: 0x00639454 File Offset: 0x00637654
		public static Offset<IAkEventMapType> CreateIAkEventMapType(FlatBufferBuilder builder, EAkEventMap Type = EAkEventMap.PlayMapMusic)
		{
			builder.StartTable(1);
			IAkEventMapType.AddType(builder, Type);
			return IAkEventMapType.EndIAkEventMapType(builder);
		}

		// Token: 0x0602D737 RID: 186167 RVA: 0x0063946A File Offset: 0x0063766A
		public static void StartIAkEventMapType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D738 RID: 186168 RVA: 0x00639473 File Offset: 0x00637673
		public static void AddType(FlatBufferBuilder builder, EAkEventMap type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D739 RID: 186169 RVA: 0x0063947E File Offset: 0x0063767E
		public static Offset<IAkEventMapType> EndIAkEventMapType(FlatBufferBuilder builder)
		{
			return new Offset<IAkEventMapType>(builder.EndTable());
		}

		// Token: 0x0602D73A RID: 186170 RVA: 0x0063948C File Offset: 0x0063768C
		public IAkEventMapTypeT UnPack()
		{
			IAkEventMapTypeT akEventMapTypeT = new IAkEventMapTypeT();
			this.UnPackTo(akEventMapTypeT);
			return akEventMapTypeT;
		}

		// Token: 0x0602D73B RID: 186171 RVA: 0x006394A7 File Offset: 0x006376A7
		public void UnPackTo(IAkEventMapTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D73C RID: 186172 RVA: 0x006394B8 File Offset: 0x006376B8
		public static Offset<IAkEventMapType> Pack(FlatBufferBuilder builder, IAkEventMapTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAkEventMapType>);
			}
			return IAkEventMapType.CreateIAkEventMapType(builder, _o.Type);
		}

		// Token: 0x04011495 RID: 70805
		private Table __p;
	}
}
