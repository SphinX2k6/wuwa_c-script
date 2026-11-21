using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F4 RID: 30708
	public struct ISetMoveSpeed : IFlatbufferObject
	{
		// Token: 0x1700E110 RID: 57616
		// (get) Token: 0x06035F1D RID: 220957 RVA: 0x00739EEE File Offset: 0x007380EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F1E RID: 220958 RVA: 0x00739EFB File Offset: 0x007380FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F1F RID: 220959 RVA: 0x00739F04 File Offset: 0x00738104
		public static ISetMoveSpeed GetRootAsISetMoveSpeed(ByteBuffer _bb)
		{
			return ISetMoveSpeed.GetRootAsISetMoveSpeed(_bb, default(ISetMoveSpeed));
		}

		// Token: 0x06035F20 RID: 220960 RVA: 0x00739F20 File Offset: 0x00738120
		public static ISetMoveSpeed GetRootAsISetMoveSpeed(ByteBuffer _bb, ISetMoveSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F21 RID: 220961 RVA: 0x00739F3D File Offset: 0x0073813D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F22 RID: 220962 RVA: 0x00739F4C File Offset: 0x0073814C
		public ISetMoveSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E111 RID: 57617
		// (get) Token: 0x06035F23 RID: 220963 RVA: 0x00739F5C File Offset: 0x0073815C
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035F24 RID: 220964 RVA: 0x00739F9C File Offset: 0x0073819C
		public static Offset<ISetMoveSpeed> CreateISetMoveSpeed(FlatBufferBuilder builder, float Speed = 0f)
		{
			builder.StartTable(1);
			ISetMoveSpeed.AddSpeed(builder, Speed);
			return ISetMoveSpeed.EndISetMoveSpeed(builder);
		}

		// Token: 0x06035F25 RID: 220965 RVA: 0x00739FB2 File Offset: 0x007381B2
		public static void StartISetMoveSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035F26 RID: 220966 RVA: 0x00739FBB File Offset: 0x007381BB
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(0, speed, 0.0);
		}

		// Token: 0x06035F27 RID: 220967 RVA: 0x00739FCE File Offset: 0x007381CE
		public static Offset<ISetMoveSpeed> EndISetMoveSpeed(FlatBufferBuilder builder)
		{
			return new Offset<ISetMoveSpeed>(builder.EndTable());
		}

		// Token: 0x06035F28 RID: 220968 RVA: 0x00739FDC File Offset: 0x007381DC
		public ISetMoveSpeedT UnPack()
		{
			ISetMoveSpeedT setMoveSpeedT = new ISetMoveSpeedT();
			this.UnPackTo(setMoveSpeedT);
			return setMoveSpeedT;
		}

		// Token: 0x06035F29 RID: 220969 RVA: 0x00739FF7 File Offset: 0x007381F7
		public void UnPackTo(ISetMoveSpeedT _o)
		{
			_o.Speed = this.Speed;
		}

		// Token: 0x06035F2A RID: 220970 RVA: 0x0073A008 File Offset: 0x00738208
		public static Offset<ISetMoveSpeed> Pack(FlatBufferBuilder builder, ISetMoveSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetMoveSpeed>);
			}
			return ISetMoveSpeed.CreateISetMoveSpeed(builder, _o.Speed);
		}

		// Token: 0x04012A40 RID: 76352
		private Table __p;
	}
}
