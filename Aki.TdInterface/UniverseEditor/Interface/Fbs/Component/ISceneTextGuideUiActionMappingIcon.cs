using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DF RID: 22751
	public struct ISceneTextGuideUiActionMappingIcon : IFlatbufferObject
	{
		// Token: 0x1700AA69 RID: 43625
		// (get) Token: 0x0602669A RID: 157338 RVA: 0x0054B346 File Offset: 0x00549546
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602669B RID: 157339 RVA: 0x0054B353 File Offset: 0x00549553
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602669C RID: 157340 RVA: 0x0054B35C File Offset: 0x0054955C
		public static ISceneTextGuideUiActionMappingIcon GetRootAsISceneTextGuideUiActionMappingIcon(ByteBuffer _bb)
		{
			return ISceneTextGuideUiActionMappingIcon.GetRootAsISceneTextGuideUiActionMappingIcon(_bb, default(ISceneTextGuideUiActionMappingIcon));
		}

		// Token: 0x0602669D RID: 157341 RVA: 0x0054B378 File Offset: 0x00549578
		public static ISceneTextGuideUiActionMappingIcon GetRootAsISceneTextGuideUiActionMappingIcon(ByteBuffer _bb, ISceneTextGuideUiActionMappingIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602669E RID: 157342 RVA: 0x0054B395 File Offset: 0x00549595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602669F RID: 157343 RVA: 0x0054B3A4 File Offset: 0x005495A4
		public ISceneTextGuideUiActionMappingIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA6A RID: 43626
		// (get) Token: 0x060266A0 RID: 157344 RVA: 0x0054B3B4 File Offset: 0x005495B4
		public int Id
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

		// Token: 0x1700AA6B RID: 43627
		// (get) Token: 0x060266A1 RID: 157345 RVA: 0x0054B3F0 File Offset: 0x005495F0
		public string ActionName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060266A2 RID: 157346 RVA: 0x0054B427 File Offset: 0x00549627
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060266A3 RID: 157347 RVA: 0x0054B436 File Offset: 0x00549636
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060266A4 RID: 157348 RVA: 0x0054B444 File Offset: 0x00549644
		public static Offset<ISceneTextGuideUiActionMappingIcon> CreateISceneTextGuideUiActionMappingIcon(FlatBufferBuilder builder, int Id = 0, StringOffset ActionNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISceneTextGuideUiActionMappingIcon.AddActionName(builder, ActionNameOffset);
			ISceneTextGuideUiActionMappingIcon.AddId(builder, Id);
			return ISceneTextGuideUiActionMappingIcon.EndISceneTextGuideUiActionMappingIcon(builder);
		}

		// Token: 0x060266A5 RID: 157349 RVA: 0x0054B461 File Offset: 0x00549661
		public static void StartISceneTextGuideUiActionMappingIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060266A6 RID: 157350 RVA: 0x0054B46A File Offset: 0x0054966A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060266A7 RID: 157351 RVA: 0x0054B475 File Offset: 0x00549675
		public static void AddActionName(FlatBufferBuilder builder, StringOffset actionNameOffset)
		{
			builder.AddOffset(1, actionNameOffset.Value, 0);
		}

		// Token: 0x060266A8 RID: 157352 RVA: 0x0054B485 File Offset: 0x00549685
		public static Offset<ISceneTextGuideUiActionMappingIcon> EndISceneTextGuideUiActionMappingIcon(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUiActionMappingIcon>(builder.EndTable());
		}

		// Token: 0x060266A9 RID: 157353 RVA: 0x0054B494 File Offset: 0x00549694
		public ISceneTextGuideUiActionMappingIconT UnPack()
		{
			ISceneTextGuideUiActionMappingIconT sceneTextGuideUiActionMappingIconT = new ISceneTextGuideUiActionMappingIconT();
			this.UnPackTo(sceneTextGuideUiActionMappingIconT);
			return sceneTextGuideUiActionMappingIconT;
		}

		// Token: 0x060266AA RID: 157354 RVA: 0x0054B4AF File Offset: 0x005496AF
		public void UnPackTo(ISceneTextGuideUiActionMappingIconT _o)
		{
			_o.Id = this.Id;
			_o.ActionName = this.ActionName;
		}

		// Token: 0x060266AB RID: 157355 RVA: 0x0054B4CC File Offset: 0x005496CC
		public static Offset<ISceneTextGuideUiActionMappingIcon> Pack(FlatBufferBuilder builder, ISceneTextGuideUiActionMappingIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextGuideUiActionMappingIcon>);
			}
			StringOffset actionNameOffset = (_o.ActionName == null) ? default(StringOffset) : builder.CreateString(_o.ActionName);
			return ISceneTextGuideUiActionMappingIcon.CreateISceneTextGuideUiActionMappingIcon(builder, _o.Id, actionNameOffset);
		}

		// Token: 0x0400EE66 RID: 61030
		private Table __p;
	}
}
