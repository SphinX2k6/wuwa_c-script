using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005977 RID: 22903
	public struct ISpeedCurveMotion : IFlatbufferObject
	{
		// Token: 0x1700ABD9 RID: 43993
		// (get) Token: 0x06026C3F RID: 158783 RVA: 0x00556236 File Offset: 0x00554436
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026C40 RID: 158784 RVA: 0x00556243 File Offset: 0x00554443
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026C41 RID: 158785 RVA: 0x0055624C File Offset: 0x0055444C
		public static ISpeedCurveMotion GetRootAsISpeedCurveMotion(ByteBuffer _bb)
		{
			return ISpeedCurveMotion.GetRootAsISpeedCurveMotion(_bb, default(ISpeedCurveMotion));
		}

		// Token: 0x06026C42 RID: 158786 RVA: 0x00556268 File Offset: 0x00554468
		public static ISpeedCurveMotion GetRootAsISpeedCurveMotion(ByteBuffer _bb, ISpeedCurveMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026C43 RID: 158787 RVA: 0x00556285 File Offset: 0x00554485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026C44 RID: 158788 RVA: 0x00556294 File Offset: 0x00554494
		public ISpeedCurveMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ABDA RID: 43994
		// (get) Token: 0x06026C45 RID: 158789 RVA: 0x005562A4 File Offset: 0x005544A4
		public string SpeedCurve
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026C46 RID: 158790 RVA: 0x005562DB File Offset: 0x005544DB
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026C47 RID: 158791 RVA: 0x005562EA File Offset: 0x005544EA
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06026C48 RID: 158792 RVA: 0x005562F8 File Offset: 0x005544F8
		public static Offset<ISpeedCurveMotion> CreateISpeedCurveMotion(FlatBufferBuilder builder, StringOffset SpeedCurveOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISpeedCurveMotion.AddSpeedCurve(builder, SpeedCurveOffset);
			return ISpeedCurveMotion.EndISpeedCurveMotion(builder);
		}

		// Token: 0x06026C49 RID: 158793 RVA: 0x0055630E File Offset: 0x0055450E
		public static void StartISpeedCurveMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026C4A RID: 158794 RVA: 0x00556317 File Offset: 0x00554517
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(0, speedCurveOffset.Value, 0);
		}

		// Token: 0x06026C4B RID: 158795 RVA: 0x00556327 File Offset: 0x00554527
		public static Offset<ISpeedCurveMotion> EndISpeedCurveMotion(FlatBufferBuilder builder)
		{
			return new Offset<ISpeedCurveMotion>(builder.EndTable());
		}

		// Token: 0x06026C4C RID: 158796 RVA: 0x00556334 File Offset: 0x00554534
		public ISpeedCurveMotionT UnPack()
		{
			ISpeedCurveMotionT speedCurveMotionT = new ISpeedCurveMotionT();
			this.UnPackTo(speedCurveMotionT);
			return speedCurveMotionT;
		}

		// Token: 0x06026C4D RID: 158797 RVA: 0x0055634F File Offset: 0x0055454F
		public void UnPackTo(ISpeedCurveMotionT _o)
		{
			_o.SpeedCurve = this.SpeedCurve;
		}

		// Token: 0x06026C4E RID: 158798 RVA: 0x00556360 File Offset: 0x00554560
		public static Offset<ISpeedCurveMotion> Pack(FlatBufferBuilder builder, ISpeedCurveMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpeedCurveMotion>);
			}
			StringOffset speedCurveOffset = (_o.SpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedCurve);
			return ISpeedCurveMotion.CreateISpeedCurveMotion(builder, speedCurveOffset);
		}

		// Token: 0x0400EF65 RID: 61285
		private Table __p;
	}
}
