using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ABD RID: 15037
	public struct IRequiredVector2 : IFlatbufferObject
	{
		// Token: 0x17006728 RID: 26408
		// (get) Token: 0x06014724 RID: 83748 RVA: 0x002FAD57 File Offset: 0x002F8F57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014725 RID: 83749 RVA: 0x002FAD64 File Offset: 0x002F8F64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014726 RID: 83750 RVA: 0x002FAD6C File Offset: 0x002F8F6C
		public static IRequiredVector2 GetRootAsIRequiredVector2(ByteBuffer _bb)
		{
			return IRequiredVector2.GetRootAsIRequiredVector2(_bb, default(IRequiredVector2));
		}

		// Token: 0x06014727 RID: 83751 RVA: 0x002FAD88 File Offset: 0x002F8F88
		public static IRequiredVector2 GetRootAsIRequiredVector2(ByteBuffer _bb, IRequiredVector2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014728 RID: 83752 RVA: 0x002FADA5 File Offset: 0x002F8FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014729 RID: 83753 RVA: 0x002FADB4 File Offset: 0x002F8FB4
		public IRequiredVector2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006729 RID: 26409
		// (get) Token: 0x0601472A RID: 83754 RVA: 0x002FADC4 File Offset: 0x002F8FC4
		public float X
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

		// Token: 0x1700672A RID: 26410
		// (get) Token: 0x0601472B RID: 83755 RVA: 0x002FAE04 File Offset: 0x002F9004
		public float Y
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

		// Token: 0x0601472C RID: 83756 RVA: 0x002FAE44 File Offset: 0x002F9044
		public static Offset<IRequiredVector2> CreateIRequiredVector2(FlatBufferBuilder builder, float X = 0f, float Y = 0f)
		{
			builder.StartTable(2);
			IRequiredVector2.AddY(builder, Y);
			IRequiredVector2.AddX(builder, X);
			return IRequiredVector2.EndIRequiredVector2(builder);
		}

		// Token: 0x0601472D RID: 83757 RVA: 0x002FAE61 File Offset: 0x002F9061
		public static void StartIRequiredVector2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601472E RID: 83758 RVA: 0x002FAE6A File Offset: 0x002F906A
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x0601472F RID: 83759 RVA: 0x002FAE7D File Offset: 0x002F907D
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06014730 RID: 83760 RVA: 0x002FAE90 File Offset: 0x002F9090
		public static Offset<IRequiredVector2> EndIRequiredVector2(FlatBufferBuilder builder)
		{
			return new Offset<IRequiredVector2>(builder.EndTable());
		}

		// Token: 0x06014731 RID: 83761 RVA: 0x002FAEA0 File Offset: 0x002F90A0
		public IRequiredVector2T UnPack()
		{
			IRequiredVector2T requiredVector2T = new IRequiredVector2T();
			this.UnPackTo(requiredVector2T);
			return requiredVector2T;
		}

		// Token: 0x06014732 RID: 83762 RVA: 0x002FAEBB File Offset: 0x002F90BB
		public void UnPackTo(IRequiredVector2T _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
		}

		// Token: 0x06014733 RID: 83763 RVA: 0x002FAED8 File Offset: 0x002F90D8
		public static Offset<IRequiredVector2> Pack(FlatBufferBuilder builder, IRequiredVector2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRequiredVector2>);
			}
			return IRequiredVector2.CreateIRequiredVector2(builder, _o.X, _o.Y);
		}

		// Token: 0x0400AF5B RID: 44891
		private Table __p;
	}
}
