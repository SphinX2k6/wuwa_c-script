using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B28 RID: 23336
	public struct IMonsterNpcInteractionGazePerform : IFlatbufferObject
	{
		// Token: 0x1700AA57 RID: 43607
		// (get) Token: 0x06026618 RID: 157208 RVA: 0x00541FF6 File Offset: 0x005401F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026619 RID: 157209 RVA: 0x00542003 File Offset: 0x00540203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602661A RID: 157210 RVA: 0x0054200C File Offset: 0x0054020C
		public static IMonsterNpcInteractionGazePerform GetRootAsIMonsterNpcInteractionGazePerform(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionGazePerform.GetRootAsIMonsterNpcInteractionGazePerform(_bb, default(IMonsterNpcInteractionGazePerform));
		}

		// Token: 0x0602661B RID: 157211 RVA: 0x00542028 File Offset: 0x00540228
		public static IMonsterNpcInteractionGazePerform GetRootAsIMonsterNpcInteractionGazePerform(ByteBuffer _bb, IMonsterNpcInteractionGazePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602661C RID: 157212 RVA: 0x00542045 File Offset: 0x00540245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602661D RID: 157213 RVA: 0x00542054 File Offset: 0x00540254
		public IMonsterNpcInteractionGazePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA58 RID: 43608
		// (get) Token: 0x0602661E RID: 157214 RVA: 0x00542064 File Offset: 0x00540264
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602661F RID: 157215 RVA: 0x005420A0 File Offset: 0x005402A0
		public static Offset<IMonsterNpcInteractionGazePerform> CreateIMonsterNpcInteractionGazePerform(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionGazePerform.AddType(builder, Type);
			return IMonsterNpcInteractionGazePerform.EndIMonsterNpcInteractionGazePerform(builder);
		}

		// Token: 0x06026620 RID: 157216 RVA: 0x005420B6 File Offset: 0x005402B6
		public static void StartIMonsterNpcInteractionGazePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026621 RID: 157217 RVA: 0x005420BF File Offset: 0x005402BF
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026622 RID: 157218 RVA: 0x005420CA File Offset: 0x005402CA
		public static Offset<IMonsterNpcInteractionGazePerform> EndIMonsterNpcInteractionGazePerform(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionGazePerform>(builder.EndTable());
		}

		// Token: 0x06026623 RID: 157219 RVA: 0x005420D8 File Offset: 0x005402D8
		public IMonsterNpcInteractionGazePerformT UnPack()
		{
			IMonsterNpcInteractionGazePerformT monsterNpcInteractionGazePerformT = new IMonsterNpcInteractionGazePerformT();
			this.UnPackTo(monsterNpcInteractionGazePerformT);
			return monsterNpcInteractionGazePerformT;
		}

		// Token: 0x06026624 RID: 157220 RVA: 0x005420F3 File Offset: 0x005402F3
		public void UnPackTo(IMonsterNpcInteractionGazePerformT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026625 RID: 157221 RVA: 0x00542104 File Offset: 0x00540304
		public static Offset<IMonsterNpcInteractionGazePerform> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionGazePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionGazePerform>);
			}
			return IMonsterNpcInteractionGazePerform.CreateIMonsterNpcInteractionGazePerform(builder, _o.Type);
		}

		// Token: 0x0400F51F RID: 62751
		private Table __p;
	}
}
