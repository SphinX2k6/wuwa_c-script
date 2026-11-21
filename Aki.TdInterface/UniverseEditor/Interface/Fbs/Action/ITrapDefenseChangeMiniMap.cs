using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C4A RID: 31818
	public struct ITrapDefenseChangeMiniMap : IFlatbufferObject
	{
		// Token: 0x1700EE38 RID: 60984
		// (get) Token: 0x060395A8 RID: 234920 RVA: 0x007BE7FB File Offset: 0x007BC9FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060395A9 RID: 234921 RVA: 0x007BE808 File Offset: 0x007BCA08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060395AA RID: 234922 RVA: 0x007BE810 File Offset: 0x007BCA10
		public static ITrapDefenseChangeMiniMap GetRootAsITrapDefenseChangeMiniMap(ByteBuffer _bb)
		{
			return ITrapDefenseChangeMiniMap.GetRootAsITrapDefenseChangeMiniMap(_bb, default(ITrapDefenseChangeMiniMap));
		}

		// Token: 0x060395AB RID: 234923 RVA: 0x007BE82C File Offset: 0x007BCA2C
		public static ITrapDefenseChangeMiniMap GetRootAsITrapDefenseChangeMiniMap(ByteBuffer _bb, ITrapDefenseChangeMiniMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060395AC RID: 234924 RVA: 0x007BE849 File Offset: 0x007BCA49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060395AD RID: 234925 RVA: 0x007BE858 File Offset: 0x007BCA58
		public ITrapDefenseChangeMiniMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE39 RID: 60985
		// (get) Token: 0x060395AE RID: 234926 RVA: 0x007BE868 File Offset: 0x007BCA68
		public int MiniMapId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060395AF RID: 234927 RVA: 0x007BE8A4 File Offset: 0x007BCAA4
		public static Offset<ITrapDefenseChangeMiniMap> CreateITrapDefenseChangeMiniMap(FlatBufferBuilder builder, int MiniMapId = 0)
		{
			builder.StartTable(1);
			ITrapDefenseChangeMiniMap.AddMiniMapId(builder, MiniMapId);
			return ITrapDefenseChangeMiniMap.EndITrapDefenseChangeMiniMap(builder);
		}

		// Token: 0x060395B0 RID: 234928 RVA: 0x007BE8BA File Offset: 0x007BCABA
		public static void StartITrapDefenseChangeMiniMap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060395B1 RID: 234929 RVA: 0x007BE8C3 File Offset: 0x007BCAC3
		public static void AddMiniMapId(FlatBufferBuilder builder, int miniMapId)
		{
			builder.AddInt(0, miniMapId, 0);
		}

		// Token: 0x060395B2 RID: 234930 RVA: 0x007BE8CE File Offset: 0x007BCACE
		public static Offset<ITrapDefenseChangeMiniMap> EndITrapDefenseChangeMiniMap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseChangeMiniMap>(builder.EndTable());
		}

		// Token: 0x060395B3 RID: 234931 RVA: 0x007BE8DC File Offset: 0x007BCADC
		public ITrapDefenseChangeMiniMapT UnPack()
		{
			ITrapDefenseChangeMiniMapT trapDefenseChangeMiniMapT = new ITrapDefenseChangeMiniMapT();
			this.UnPackTo(trapDefenseChangeMiniMapT);
			return trapDefenseChangeMiniMapT;
		}

		// Token: 0x060395B4 RID: 234932 RVA: 0x007BE8F7 File Offset: 0x007BCAF7
		public void UnPackTo(ITrapDefenseChangeMiniMapT _o)
		{
			_o.MiniMapId = this.MiniMapId;
		}

		// Token: 0x060395B5 RID: 234933 RVA: 0x007BE908 File Offset: 0x007BCB08
		public static Offset<ITrapDefenseChangeMiniMap> Pack(FlatBufferBuilder builder, ITrapDefenseChangeMiniMapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseChangeMiniMap>);
			}
			return ITrapDefenseChangeMiniMap.CreateITrapDefenseChangeMiniMap(builder, _o.MiniMapId);
		}

		// Token: 0x04013308 RID: 78600
		private Table __p;
	}
}
