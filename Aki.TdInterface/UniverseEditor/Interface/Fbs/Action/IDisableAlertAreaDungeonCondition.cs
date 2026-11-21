using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C32 RID: 27698
	public struct IDisableAlertAreaDungeonCondition : IFlatbufferObject
	{
		// Token: 0x1700CAF1 RID: 51953
		// (get) Token: 0x0602FA90 RID: 195216 RVA: 0x0067E104 File Offset: 0x0067C304
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA91 RID: 195217 RVA: 0x0067E111 File Offset: 0x0067C311
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA92 RID: 195218 RVA: 0x0067E118 File Offset: 0x0067C318
		public static IDisableAlertAreaDungeonCondition GetRootAsIDisableAlertAreaDungeonCondition(ByteBuffer _bb)
		{
			return IDisableAlertAreaDungeonCondition.GetRootAsIDisableAlertAreaDungeonCondition(_bb, default(IDisableAlertAreaDungeonCondition));
		}

		// Token: 0x0602FA93 RID: 195219 RVA: 0x0067E134 File Offset: 0x0067C334
		public static IDisableAlertAreaDungeonCondition GetRootAsIDisableAlertAreaDungeonCondition(ByteBuffer _bb, IDisableAlertAreaDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA94 RID: 195220 RVA: 0x0067E151 File Offset: 0x0067C351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA95 RID: 195221 RVA: 0x0067E160 File Offset: 0x0067C360
		public IDisableAlertAreaDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAF2 RID: 51954
		// (get) Token: 0x0602FA96 RID: 195222 RVA: 0x0067E170 File Offset: 0x0067C370
		public EDisableAlertAreaCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return (EDisableAlertAreaCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CAF3 RID: 51955
		// (get) Token: 0x0602FA97 RID: 195223 RVA: 0x0067E1AC File Offset: 0x0067C3AC
		public int RelatedDungeonId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA98 RID: 195224 RVA: 0x0067E1E8 File Offset: 0x0067C3E8
		public static Offset<IDisableAlertAreaDungeonCondition> CreateIDisableAlertAreaDungeonCondition(FlatBufferBuilder builder, EDisableAlertAreaCondition Type = EDisableAlertAreaCondition.DungeonCondition, int RelatedDungeonId = 0)
		{
			builder.StartTable(2);
			IDisableAlertAreaDungeonCondition.AddRelatedDungeonId(builder, RelatedDungeonId);
			IDisableAlertAreaDungeonCondition.AddType(builder, Type);
			return IDisableAlertAreaDungeonCondition.EndIDisableAlertAreaDungeonCondition(builder);
		}

		// Token: 0x0602FA99 RID: 195225 RVA: 0x0067E205 File Offset: 0x0067C405
		public static void StartIDisableAlertAreaDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FA9A RID: 195226 RVA: 0x0067E20E File Offset: 0x0067C40E
		public static void AddType(FlatBufferBuilder builder, EDisableAlertAreaCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA9B RID: 195227 RVA: 0x0067E219 File Offset: 0x0067C419
		public static void AddRelatedDungeonId(FlatBufferBuilder builder, int relatedDungeonId)
		{
			builder.AddInt(1, relatedDungeonId, 0);
		}

		// Token: 0x0602FA9C RID: 195228 RVA: 0x0067E224 File Offset: 0x0067C424
		public static Offset<IDisableAlertAreaDungeonCondition> EndIDisableAlertAreaDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAlertAreaDungeonCondition>(builder.EndTable());
		}

		// Token: 0x0602FA9D RID: 195229 RVA: 0x0067E234 File Offset: 0x0067C434
		public IDisableAlertAreaDungeonConditionT UnPack()
		{
			IDisableAlertAreaDungeonConditionT disableAlertAreaDungeonConditionT = new IDisableAlertAreaDungeonConditionT();
			this.UnPackTo(disableAlertAreaDungeonConditionT);
			return disableAlertAreaDungeonConditionT;
		}

		// Token: 0x0602FA9E RID: 195230 RVA: 0x0067E24F File Offset: 0x0067C44F
		public void UnPackTo(IDisableAlertAreaDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.RelatedDungeonId = this.RelatedDungeonId;
		}

		// Token: 0x0602FA9F RID: 195231 RVA: 0x0067E26C File Offset: 0x0067C46C
		public static Offset<IDisableAlertAreaDungeonCondition> Pack(FlatBufferBuilder builder, IDisableAlertAreaDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAlertAreaDungeonCondition>);
			}
			return IDisableAlertAreaDungeonCondition.CreateIDisableAlertAreaDungeonCondition(builder, _o.Type, _o.RelatedDungeonId);
		}

		// Token: 0x04011A3D RID: 72253
		private Table __p;
	}
}
