using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005874 RID: 22644
	public struct IGazeNextPointAfterInteract : IFlatbufferObject
	{
		// Token: 0x1700A407 RID: 41991
		// (get) Token: 0x06024B3C RID: 150332 RVA: 0x0050AAA3 File Offset: 0x00508CA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B3D RID: 150333 RVA: 0x0050AAB0 File Offset: 0x00508CB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B3E RID: 150334 RVA: 0x0050AAB8 File Offset: 0x00508CB8
		public static IGazeNextPointAfterInteract GetRootAsIGazeNextPointAfterInteract(ByteBuffer _bb)
		{
			return IGazeNextPointAfterInteract.GetRootAsIGazeNextPointAfterInteract(_bb, default(IGazeNextPointAfterInteract));
		}

		// Token: 0x06024B3F RID: 150335 RVA: 0x0050AAD4 File Offset: 0x00508CD4
		public static IGazeNextPointAfterInteract GetRootAsIGazeNextPointAfterInteract(ByteBuffer _bb, IGazeNextPointAfterInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B40 RID: 150336 RVA: 0x0050AAF1 File Offset: 0x00508CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B41 RID: 150337 RVA: 0x0050AB00 File Offset: 0x00508D00
		public IGazeNextPointAfterInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A408 RID: 41992
		// (get) Token: 0x06024B42 RID: 150338 RVA: 0x0050AB10 File Offset: 0x00508D10
		public IGazeCondition? GazeCondition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IGazeCondition?(default(IGazeCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A409 RID: 41993
		// (get) Token: 0x06024B43 RID: 150339 RVA: 0x0050AB70 File Offset: 0x00508D70
		public IGazePerformance? GazePerformance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGazePerformance?(default(IGazePerformance).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024B44 RID: 150340 RVA: 0x0050ABCD File Offset: 0x00508DCD
		public static Offset<IGazeNextPointAfterInteract> CreateIGazeNextPointAfterInteract(FlatBufferBuilder builder, Offset<IGazeCondition> GazeConditionOffset = default(Offset<IGazeCondition>), Offset<IGazePerformance> GazePerformanceOffset = default(Offset<IGazePerformance>))
		{
			builder.StartTable(2);
			IGazeNextPointAfterInteract.AddGazePerformance(builder, GazePerformanceOffset);
			IGazeNextPointAfterInteract.AddGazeCondition(builder, GazeConditionOffset);
			return IGazeNextPointAfterInteract.EndIGazeNextPointAfterInteract(builder);
		}

		// Token: 0x06024B45 RID: 150341 RVA: 0x0050ABEA File Offset: 0x00508DEA
		public static void StartIGazeNextPointAfterInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024B46 RID: 150342 RVA: 0x0050ABF3 File Offset: 0x00508DF3
		public static void AddGazeCondition(FlatBufferBuilder builder, Offset<IGazeCondition> gazeConditionOffset)
		{
			builder.AddOffset(0, gazeConditionOffset.Value, 0);
		}

		// Token: 0x06024B47 RID: 150343 RVA: 0x0050AC03 File Offset: 0x00508E03
		public static void AddGazePerformance(FlatBufferBuilder builder, Offset<IGazePerformance> gazePerformanceOffset)
		{
			builder.AddOffset(1, gazePerformanceOffset.Value, 0);
		}

		// Token: 0x06024B48 RID: 150344 RVA: 0x0050AC13 File Offset: 0x00508E13
		public static Offset<IGazeNextPointAfterInteract> EndIGazeNextPointAfterInteract(FlatBufferBuilder builder)
		{
			return new Offset<IGazeNextPointAfterInteract>(builder.EndTable());
		}

		// Token: 0x06024B49 RID: 150345 RVA: 0x0050AC20 File Offset: 0x00508E20
		public IGazeNextPointAfterInteractT UnPack()
		{
			IGazeNextPointAfterInteractT gazeNextPointAfterInteractT = new IGazeNextPointAfterInteractT();
			this.UnPackTo(gazeNextPointAfterInteractT);
			return gazeNextPointAfterInteractT;
		}

		// Token: 0x06024B4A RID: 150346 RVA: 0x0050AC3C File Offset: 0x00508E3C
		public void UnPackTo(IGazeNextPointAfterInteractT _o)
		{
			_o.GazeCondition = ((this.GazeCondition != null) ? this.GazeCondition.Value.UnPack() : null);
			_o.GazePerformance = ((this.GazePerformance != null) ? this.GazePerformance.Value.UnPack() : null);
		}

		// Token: 0x06024B4B RID: 150347 RVA: 0x0050ACA8 File Offset: 0x00508EA8
		public static Offset<IGazeNextPointAfterInteract> Pack(FlatBufferBuilder builder, IGazeNextPointAfterInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGazeNextPointAfterInteract>);
			}
			Offset<IGazeCondition> gazeConditionOffset = (_o.GazeCondition == null) ? default(Offset<IGazeCondition>) : IGazeCondition.Pack(builder, _o.GazeCondition);
			Offset<IGazePerformance> gazePerformanceOffset = (_o.GazePerformance == null) ? default(Offset<IGazePerformance>) : IGazePerformance.Pack(builder, _o.GazePerformance);
			return IGazeNextPointAfterInteract.CreateIGazeNextPointAfterInteract(builder, gazeConditionOffset, gazePerformanceOffset);
		}

		// Token: 0x0400F0C0 RID: 61632
		private Table __p;
	}
}
