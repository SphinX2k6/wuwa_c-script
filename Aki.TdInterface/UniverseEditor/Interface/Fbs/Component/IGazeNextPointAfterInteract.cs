using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F1 RID: 21233
	public struct IGazeNextPointAfterInteract : IFlatbufferObject
	{
		// Token: 0x17009BD6 RID: 39894
		// (get) Token: 0x06022AA2 RID: 141986 RVA: 0x004CDF77 File Offset: 0x004CC177
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022AA3 RID: 141987 RVA: 0x004CDF84 File Offset: 0x004CC184
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022AA4 RID: 141988 RVA: 0x004CDF8C File Offset: 0x004CC18C
		public static IGazeNextPointAfterInteract GetRootAsIGazeNextPointAfterInteract(ByteBuffer _bb)
		{
			return IGazeNextPointAfterInteract.GetRootAsIGazeNextPointAfterInteract(_bb, default(IGazeNextPointAfterInteract));
		}

		// Token: 0x06022AA5 RID: 141989 RVA: 0x004CDFA8 File Offset: 0x004CC1A8
		public static IGazeNextPointAfterInteract GetRootAsIGazeNextPointAfterInteract(ByteBuffer _bb, IGazeNextPointAfterInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022AA6 RID: 141990 RVA: 0x004CDFC5 File Offset: 0x004CC1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022AA7 RID: 141991 RVA: 0x004CDFD4 File Offset: 0x004CC1D4
		public IGazeNextPointAfterInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BD7 RID: 39895
		// (get) Token: 0x06022AA8 RID: 141992 RVA: 0x004CDFE4 File Offset: 0x004CC1E4
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

		// Token: 0x17009BD8 RID: 39896
		// (get) Token: 0x06022AA9 RID: 141993 RVA: 0x004CE044 File Offset: 0x004CC244
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

		// Token: 0x06022AAA RID: 141994 RVA: 0x004CE0A1 File Offset: 0x004CC2A1
		public static Offset<IGazeNextPointAfterInteract> CreateIGazeNextPointAfterInteract(FlatBufferBuilder builder, Offset<IGazeCondition> GazeConditionOffset = default(Offset<IGazeCondition>), Offset<IGazePerformance> GazePerformanceOffset = default(Offset<IGazePerformance>))
		{
			builder.StartTable(2);
			IGazeNextPointAfterInteract.AddGazePerformance(builder, GazePerformanceOffset);
			IGazeNextPointAfterInteract.AddGazeCondition(builder, GazeConditionOffset);
			return IGazeNextPointAfterInteract.EndIGazeNextPointAfterInteract(builder);
		}

		// Token: 0x06022AAB RID: 141995 RVA: 0x004CE0BE File Offset: 0x004CC2BE
		public static void StartIGazeNextPointAfterInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022AAC RID: 141996 RVA: 0x004CE0C7 File Offset: 0x004CC2C7
		public static void AddGazeCondition(FlatBufferBuilder builder, Offset<IGazeCondition> gazeConditionOffset)
		{
			builder.AddOffset(0, gazeConditionOffset.Value, 0);
		}

		// Token: 0x06022AAD RID: 141997 RVA: 0x004CE0D7 File Offset: 0x004CC2D7
		public static void AddGazePerformance(FlatBufferBuilder builder, Offset<IGazePerformance> gazePerformanceOffset)
		{
			builder.AddOffset(1, gazePerformanceOffset.Value, 0);
		}

		// Token: 0x06022AAE RID: 141998 RVA: 0x004CE0E7 File Offset: 0x004CC2E7
		public static Offset<IGazeNextPointAfterInteract> EndIGazeNextPointAfterInteract(FlatBufferBuilder builder)
		{
			return new Offset<IGazeNextPointAfterInteract>(builder.EndTable());
		}

		// Token: 0x06022AAF RID: 141999 RVA: 0x004CE0F4 File Offset: 0x004CC2F4
		public IGazeNextPointAfterInteractT UnPack()
		{
			IGazeNextPointAfterInteractT gazeNextPointAfterInteractT = new IGazeNextPointAfterInteractT();
			this.UnPackTo(gazeNextPointAfterInteractT);
			return gazeNextPointAfterInteractT;
		}

		// Token: 0x06022AB0 RID: 142000 RVA: 0x004CE110 File Offset: 0x004CC310
		public void UnPackTo(IGazeNextPointAfterInteractT _o)
		{
			_o.GazeCondition = ((this.GazeCondition != null) ? this.GazeCondition.Value.UnPack() : null);
			_o.GazePerformance = ((this.GazePerformance != null) ? this.GazePerformance.Value.UnPack() : null);
		}

		// Token: 0x06022AB1 RID: 142001 RVA: 0x004CE17C File Offset: 0x004CC37C
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

		// Token: 0x0400E494 RID: 58516
		private Table __p;
	}
}
