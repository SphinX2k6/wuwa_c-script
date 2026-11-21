using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF6 RID: 23798
	public struct IPatrolCycleLooply : IFlatbufferObject
	{
		// Token: 0x1700AEE4 RID: 44772
		// (get) Token: 0x06027862 RID: 161890 RVA: 0x00568840 File Offset: 0x00566A40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027863 RID: 161891 RVA: 0x0056884D File Offset: 0x00566A4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027864 RID: 161892 RVA: 0x00568854 File Offset: 0x00566A54
		public static IPatrolCycleLooply GetRootAsIPatrolCycleLooply(ByteBuffer _bb)
		{
			return IPatrolCycleLooply.GetRootAsIPatrolCycleLooply(_bb, default(IPatrolCycleLooply));
		}

		// Token: 0x06027865 RID: 161893 RVA: 0x00568870 File Offset: 0x00566A70
		public static IPatrolCycleLooply GetRootAsIPatrolCycleLooply(ByteBuffer _bb, IPatrolCycleLooply obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027866 RID: 161894 RVA: 0x0056888D File Offset: 0x00566A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027867 RID: 161895 RVA: 0x0056889C File Offset: 0x00566A9C
		public IPatrolCycleLooply __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEE5 RID: 44773
		// (get) Token: 0x06027868 RID: 161896 RVA: 0x005688AC File Offset: 0x00566AAC
		public EPatrolCycleMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolCycleMode.Loop;
				}
				return (EPatrolCycleMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AEE6 RID: 44774
		// (get) Token: 0x06027869 RID: 161897 RVA: 0x005688E8 File Offset: 0x00566AE8
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602786A RID: 161898 RVA: 0x00568927 File Offset: 0x00566B27
		public static Offset<IPatrolCycleLooply> CreateIPatrolCycleLooply(FlatBufferBuilder builder, EPatrolCycleMode Type = EPatrolCycleMode.Loop, bool IsCircle = false)
		{
			builder.StartTable(2);
			IPatrolCycleLooply.AddIsCircle(builder, IsCircle);
			IPatrolCycleLooply.AddType(builder, Type);
			return IPatrolCycleLooply.EndIPatrolCycleLooply(builder);
		}

		// Token: 0x0602786B RID: 161899 RVA: 0x00568944 File Offset: 0x00566B44
		public static void StartIPatrolCycleLooply(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602786C RID: 161900 RVA: 0x0056894D File Offset: 0x00566B4D
		public static void AddType(FlatBufferBuilder builder, EPatrolCycleMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602786D RID: 161901 RVA: 0x00568958 File Offset: 0x00566B58
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(1, isCircle, false);
		}

		// Token: 0x0602786E RID: 161902 RVA: 0x00568963 File Offset: 0x00566B63
		public static Offset<IPatrolCycleLooply> EndIPatrolCycleLooply(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolCycleLooply>(builder.EndTable());
		}

		// Token: 0x0602786F RID: 161903 RVA: 0x00568970 File Offset: 0x00566B70
		public IPatrolCycleLooplyT UnPack()
		{
			IPatrolCycleLooplyT patrolCycleLooplyT = new IPatrolCycleLooplyT();
			this.UnPackTo(patrolCycleLooplyT);
			return patrolCycleLooplyT;
		}

		// Token: 0x06027870 RID: 161904 RVA: 0x0056898B File Offset: 0x00566B8B
		public void UnPackTo(IPatrolCycleLooplyT _o)
		{
			_o.Type = this.Type;
			_o.IsCircle = this.IsCircle;
		}

		// Token: 0x06027871 RID: 161905 RVA: 0x005689A8 File Offset: 0x00566BA8
		public static Offset<IPatrolCycleLooply> Pack(FlatBufferBuilder builder, IPatrolCycleLooplyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolCycleLooply>);
			}
			return IPatrolCycleLooply.CreateIPatrolCycleLooply(builder, _o.Type, _o.IsCircle);
		}

		// Token: 0x0400F834 RID: 63540
		private Table __p;
	}
}
