using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B32 RID: 23346
	public struct IViewDistanceMode : IFlatbufferObject
	{
		// Token: 0x1700B036 RID: 45110
		// (get) Token: 0x06027E64 RID: 163428 RVA: 0x0057C844 File Offset: 0x0057AA44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E65 RID: 163429 RVA: 0x0057C851 File Offset: 0x0057AA51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E66 RID: 163430 RVA: 0x0057C858 File Offset: 0x0057AA58
		public static IViewDistanceMode GetRootAsIViewDistanceMode(ByteBuffer _bb)
		{
			return IViewDistanceMode.GetRootAsIViewDistanceMode(_bb, default(IViewDistanceMode));
		}

		// Token: 0x06027E67 RID: 163431 RVA: 0x0057C874 File Offset: 0x0057AA74
		public static IViewDistanceMode GetRootAsIViewDistanceMode(ByteBuffer _bb, IViewDistanceMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E68 RID: 163432 RVA: 0x0057C891 File Offset: 0x0057AA91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E69 RID: 163433 RVA: 0x0057C8A0 File Offset: 0x0057AAA0
		public IViewDistanceMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B037 RID: 45111
		// (get) Token: 0x06027E6A RID: 163434 RVA: 0x0057C8B0 File Offset: 0x0057AAB0
		public EViewDistanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewDistanceType.Low;
				}
				return (EViewDistanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027E6B RID: 163435 RVA: 0x0057C8EC File Offset: 0x0057AAEC
		public static Offset<IViewDistanceMode> CreateIViewDistanceMode(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			IViewDistanceMode.AddType(builder, Type);
			return IViewDistanceMode.EndIViewDistanceMode(builder);
		}

		// Token: 0x06027E6C RID: 163436 RVA: 0x0057C902 File Offset: 0x0057AB02
		public static void StartIViewDistanceMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027E6D RID: 163437 RVA: 0x0057C90B File Offset: 0x0057AB0B
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027E6E RID: 163438 RVA: 0x0057C916 File Offset: 0x0057AB16
		public static Offset<IViewDistanceMode> EndIViewDistanceMode(FlatBufferBuilder builder)
		{
			return new Offset<IViewDistanceMode>(builder.EndTable());
		}

		// Token: 0x06027E6F RID: 163439 RVA: 0x0057C924 File Offset: 0x0057AB24
		public IViewDistanceModeT UnPack()
		{
			IViewDistanceModeT viewDistanceModeT = new IViewDistanceModeT();
			this.UnPackTo(viewDistanceModeT);
			return viewDistanceModeT;
		}

		// Token: 0x06027E70 RID: 163440 RVA: 0x0057C93F File Offset: 0x0057AB3F
		public void UnPackTo(IViewDistanceModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027E71 RID: 163441 RVA: 0x0057C950 File Offset: 0x0057AB50
		public static Offset<IViewDistanceMode> Pack(FlatBufferBuilder builder, IViewDistanceModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IViewDistanceMode>);
			}
			return IViewDistanceMode.CreateIViewDistanceMode(builder, _o.Type);
		}

		// Token: 0x0400F258 RID: 62040
		private Table __p;
	}
}
