using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558A RID: 21898
	public struct IMonsterNpcInteractionGazePerform : IFlatbufferObject
	{
		// Token: 0x1700A1CF RID: 41423
		// (get) Token: 0x0602440B RID: 148491 RVA: 0x00501A7E File Offset: 0x004FFC7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602440C RID: 148492 RVA: 0x00501A8B File Offset: 0x004FFC8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602440D RID: 148493 RVA: 0x00501A94 File Offset: 0x004FFC94
		public static IMonsterNpcInteractionGazePerform GetRootAsIMonsterNpcInteractionGazePerform(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionGazePerform.GetRootAsIMonsterNpcInteractionGazePerform(_bb, default(IMonsterNpcInteractionGazePerform));
		}

		// Token: 0x0602440E RID: 148494 RVA: 0x00501AB0 File Offset: 0x004FFCB0
		public static IMonsterNpcInteractionGazePerform GetRootAsIMonsterNpcInteractionGazePerform(ByteBuffer _bb, IMonsterNpcInteractionGazePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602440F RID: 148495 RVA: 0x00501ACD File Offset: 0x004FFCCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024410 RID: 148496 RVA: 0x00501ADC File Offset: 0x004FFCDC
		public IMonsterNpcInteractionGazePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1D0 RID: 41424
		// (get) Token: 0x06024411 RID: 148497 RVA: 0x00501AEC File Offset: 0x004FFCEC
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

		// Token: 0x06024412 RID: 148498 RVA: 0x00501B28 File Offset: 0x004FFD28
		public static Offset<IMonsterNpcInteractionGazePerform> CreateIMonsterNpcInteractionGazePerform(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionGazePerform.AddType(builder, Type);
			return IMonsterNpcInteractionGazePerform.EndIMonsterNpcInteractionGazePerform(builder);
		}

		// Token: 0x06024413 RID: 148499 RVA: 0x00501B3E File Offset: 0x004FFD3E
		public static void StartIMonsterNpcInteractionGazePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024414 RID: 148500 RVA: 0x00501B47 File Offset: 0x004FFD47
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024415 RID: 148501 RVA: 0x00501B52 File Offset: 0x004FFD52
		public static Offset<IMonsterNpcInteractionGazePerform> EndIMonsterNpcInteractionGazePerform(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionGazePerform>(builder.EndTable());
		}

		// Token: 0x06024416 RID: 148502 RVA: 0x00501B60 File Offset: 0x004FFD60
		public IMonsterNpcInteractionGazePerformT UnPack()
		{
			IMonsterNpcInteractionGazePerformT monsterNpcInteractionGazePerformT = new IMonsterNpcInteractionGazePerformT();
			this.UnPackTo(monsterNpcInteractionGazePerformT);
			return monsterNpcInteractionGazePerformT;
		}

		// Token: 0x06024417 RID: 148503 RVA: 0x00501B7B File Offset: 0x004FFD7B
		public void UnPackTo(IMonsterNpcInteractionGazePerformT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024418 RID: 148504 RVA: 0x00501B8C File Offset: 0x004FFD8C
		public static Offset<IMonsterNpcInteractionGazePerform> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionGazePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionGazePerform>);
			}
			return IMonsterNpcInteractionGazePerform.CreateIMonsterNpcInteractionGazePerform(builder, _o.Type);
		}

		// Token: 0x0400E8BD RID: 59581
		private Table __p;
	}
}
