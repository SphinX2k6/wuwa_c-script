using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006148 RID: 24904
	public struct IViewDistanceMode : IFlatbufferObject
	{
		// Token: 0x1700B97E RID: 47486
		// (get) Token: 0x0602A428 RID: 173096 RVA: 0x005C4298 File Offset: 0x005C2498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A429 RID: 173097 RVA: 0x005C42A5 File Offset: 0x005C24A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A42A RID: 173098 RVA: 0x005C42AC File Offset: 0x005C24AC
		public static IViewDistanceMode GetRootAsIViewDistanceMode(ByteBuffer _bb)
		{
			return IViewDistanceMode.GetRootAsIViewDistanceMode(_bb, default(IViewDistanceMode));
		}

		// Token: 0x0602A42B RID: 173099 RVA: 0x005C42C8 File Offset: 0x005C24C8
		public static IViewDistanceMode GetRootAsIViewDistanceMode(ByteBuffer _bb, IViewDistanceMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A42C RID: 173100 RVA: 0x005C42E5 File Offset: 0x005C24E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A42D RID: 173101 RVA: 0x005C42F4 File Offset: 0x005C24F4
		public IViewDistanceMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B97F RID: 47487
		// (get) Token: 0x0602A42E RID: 173102 RVA: 0x005C4304 File Offset: 0x005C2504
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

		// Token: 0x0602A42F RID: 173103 RVA: 0x005C4340 File Offset: 0x005C2540
		public static Offset<IViewDistanceMode> CreateIViewDistanceMode(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			IViewDistanceMode.AddType(builder, Type);
			return IViewDistanceMode.EndIViewDistanceMode(builder);
		}

		// Token: 0x0602A430 RID: 173104 RVA: 0x005C4356 File Offset: 0x005C2556
		public static void StartIViewDistanceMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A431 RID: 173105 RVA: 0x005C435F File Offset: 0x005C255F
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A432 RID: 173106 RVA: 0x005C436A File Offset: 0x005C256A
		public static Offset<IViewDistanceMode> EndIViewDistanceMode(FlatBufferBuilder builder)
		{
			return new Offset<IViewDistanceMode>(builder.EndTable());
		}

		// Token: 0x0602A433 RID: 173107 RVA: 0x005C4378 File Offset: 0x005C2578
		public IViewDistanceModeT UnPack()
		{
			IViewDistanceModeT viewDistanceModeT = new IViewDistanceModeT();
			this.UnPackTo(viewDistanceModeT);
			return viewDistanceModeT;
		}

		// Token: 0x0602A434 RID: 173108 RVA: 0x005C4393 File Offset: 0x005C2593
		public void UnPackTo(IViewDistanceModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A435 RID: 173109 RVA: 0x005C43A4 File Offset: 0x005C25A4
		public static Offset<IViewDistanceMode> Pack(FlatBufferBuilder builder, IViewDistanceModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IViewDistanceMode>);
			}
			return IViewDistanceMode.CreateIViewDistanceMode(builder, _o.Type);
		}

		// Token: 0x0400FF5E RID: 65374
		private Table __p;
	}
}
