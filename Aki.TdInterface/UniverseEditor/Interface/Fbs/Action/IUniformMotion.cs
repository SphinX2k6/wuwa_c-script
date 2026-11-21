using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CAD RID: 31917
	public struct IUniformMotion : IFlatbufferObject
	{
		// Token: 0x1700EEF7 RID: 61175
		// (get) Token: 0x0603993B RID: 235835 RVA: 0x007C523C File Offset: 0x007C343C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603993C RID: 235836 RVA: 0x007C5249 File Offset: 0x007C3449
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603993D RID: 235837 RVA: 0x007C5250 File Offset: 0x007C3450
		public static IUniformMotion GetRootAsIUniformMotion(ByteBuffer _bb)
		{
			return IUniformMotion.GetRootAsIUniformMotion(_bb, default(IUniformMotion));
		}

		// Token: 0x0603993E RID: 235838 RVA: 0x007C526C File Offset: 0x007C346C
		public static IUniformMotion GetRootAsIUniformMotion(ByteBuffer _bb, IUniformMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603993F RID: 235839 RVA: 0x007C5289 File Offset: 0x007C3489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039940 RID: 235840 RVA: 0x007C5298 File Offset: 0x007C3498
		public IUniformMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEF8 RID: 61176
		// (get) Token: 0x06039941 RID: 235841 RVA: 0x007C52A8 File Offset: 0x007C34A8
		public EMoveMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveMotion.UniformMotion;
				}
				return (EMoveMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EEF9 RID: 61177
		// (get) Token: 0x06039942 RID: 235842 RVA: 0x007C52E4 File Offset: 0x007C34E4
		public float Time
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039943 RID: 235843 RVA: 0x007C5324 File Offset: 0x007C3524
		public static Offset<IUniformMotion> CreateIUniformMotion(FlatBufferBuilder builder, EMoveMotion Type = EMoveMotion.UniformMotion, float Time = 0f)
		{
			builder.StartTable(2);
			IUniformMotion.AddTime(builder, Time);
			IUniformMotion.AddType(builder, Type);
			return IUniformMotion.EndIUniformMotion(builder);
		}

		// Token: 0x06039944 RID: 235844 RVA: 0x007C5341 File Offset: 0x007C3541
		public static void StartIUniformMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039945 RID: 235845 RVA: 0x007C534A File Offset: 0x007C354A
		public static void AddType(FlatBufferBuilder builder, EMoveMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039946 RID: 235846 RVA: 0x007C5355 File Offset: 0x007C3555
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06039947 RID: 235847 RVA: 0x007C5368 File Offset: 0x007C3568
		public static Offset<IUniformMotion> EndIUniformMotion(FlatBufferBuilder builder)
		{
			return new Offset<IUniformMotion>(builder.EndTable());
		}

		// Token: 0x06039948 RID: 235848 RVA: 0x007C5378 File Offset: 0x007C3578
		public IUniformMotionT UnPack()
		{
			IUniformMotionT uniformMotionT = new IUniformMotionT();
			this.UnPackTo(uniformMotionT);
			return uniformMotionT;
		}

		// Token: 0x06039949 RID: 235849 RVA: 0x007C5393 File Offset: 0x007C3593
		public void UnPackTo(IUniformMotionT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
		}

		// Token: 0x0603994A RID: 235850 RVA: 0x007C53B0 File Offset: 0x007C35B0
		public static Offset<IUniformMotion> Pack(FlatBufferBuilder builder, IUniformMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUniformMotion>);
			}
			return IUniformMotion.CreateIUniformMotion(builder, _o.Type, _o.Time);
		}

		// Token: 0x040133B1 RID: 78769
		private Table __p;
	}
}
