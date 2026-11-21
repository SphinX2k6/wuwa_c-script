using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2C RID: 27692
	public struct IDisableAlertAreaCondition : IFlatbufferObject
	{
		// Token: 0x1700CAEC RID: 51948
		// (get) Token: 0x0602FA70 RID: 195184 RVA: 0x0067DE42 File Offset: 0x0067C042
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA71 RID: 195185 RVA: 0x0067DE4F File Offset: 0x0067C04F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA72 RID: 195186 RVA: 0x0067DE58 File Offset: 0x0067C058
		public static IDisableAlertAreaCondition GetRootAsIDisableAlertAreaCondition(ByteBuffer _bb)
		{
			return IDisableAlertAreaCondition.GetRootAsIDisableAlertAreaCondition(_bb, default(IDisableAlertAreaCondition));
		}

		// Token: 0x0602FA73 RID: 195187 RVA: 0x0067DE74 File Offset: 0x0067C074
		public static IDisableAlertAreaCondition GetRootAsIDisableAlertAreaCondition(ByteBuffer _bb, IDisableAlertAreaCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA74 RID: 195188 RVA: 0x0067DE91 File Offset: 0x0067C091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA75 RID: 195189 RVA: 0x0067DEA0 File Offset: 0x0067C0A0
		public IDisableAlertAreaCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAED RID: 51949
		// (get) Token: 0x0602FA76 RID: 195190 RVA: 0x0067DEB0 File Offset: 0x0067C0B0
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

		// Token: 0x0602FA77 RID: 195191 RVA: 0x0067DEEC File Offset: 0x0067C0EC
		public static Offset<IDisableAlertAreaCondition> CreateIDisableAlertAreaCondition(FlatBufferBuilder builder, EDisableAlertAreaCondition Type = EDisableAlertAreaCondition.DungeonCondition)
		{
			builder.StartTable(1);
			IDisableAlertAreaCondition.AddType(builder, Type);
			return IDisableAlertAreaCondition.EndIDisableAlertAreaCondition(builder);
		}

		// Token: 0x0602FA78 RID: 195192 RVA: 0x0067DF02 File Offset: 0x0067C102
		public static void StartIDisableAlertAreaCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA79 RID: 195193 RVA: 0x0067DF0B File Offset: 0x0067C10B
		public static void AddType(FlatBufferBuilder builder, EDisableAlertAreaCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA7A RID: 195194 RVA: 0x0067DF16 File Offset: 0x0067C116
		public static Offset<IDisableAlertAreaCondition> EndIDisableAlertAreaCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAlertAreaCondition>(builder.EndTable());
		}

		// Token: 0x0602FA7B RID: 195195 RVA: 0x0067DF24 File Offset: 0x0067C124
		public IDisableAlertAreaConditionT UnPack()
		{
			IDisableAlertAreaConditionT disableAlertAreaConditionT = new IDisableAlertAreaConditionT();
			this.UnPackTo(disableAlertAreaConditionT);
			return disableAlertAreaConditionT;
		}

		// Token: 0x0602FA7C RID: 195196 RVA: 0x0067DF3F File Offset: 0x0067C13F
		public void UnPackTo(IDisableAlertAreaConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA7D RID: 195197 RVA: 0x0067DF50 File Offset: 0x0067C150
		public static Offset<IDisableAlertAreaCondition> Pack(FlatBufferBuilder builder, IDisableAlertAreaConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAlertAreaCondition>);
			}
			return IDisableAlertAreaCondition.CreateIDisableAlertAreaCondition(builder, _o.Type);
		}

		// Token: 0x04011A34 RID: 72244
		private Table __p;
	}
}
