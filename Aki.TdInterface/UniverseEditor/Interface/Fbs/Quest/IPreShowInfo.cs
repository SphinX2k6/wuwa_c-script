using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F4 RID: 17396
	public struct IPreShowInfo : IFlatbufferObject
	{
		// Token: 0x170077E0 RID: 30688
		// (get) Token: 0x06018B8F RID: 101263 RVA: 0x003861C0 File Offset: 0x003843C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B90 RID: 101264 RVA: 0x003861CD File Offset: 0x003843CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B91 RID: 101265 RVA: 0x003861D4 File Offset: 0x003843D4
		public static IPreShowInfo GetRootAsIPreShowInfo(ByteBuffer _bb)
		{
			return IPreShowInfo.GetRootAsIPreShowInfo(_bb, default(IPreShowInfo));
		}

		// Token: 0x06018B92 RID: 101266 RVA: 0x003861F0 File Offset: 0x003843F0
		public static IPreShowInfo GetRootAsIPreShowInfo(ByteBuffer _bb, IPreShowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B93 RID: 101267 RVA: 0x0038620D File Offset: 0x0038440D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B94 RID: 101268 RVA: 0x0038621C File Offset: 0x0038441C
		public IPreShowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077E1 RID: 30689
		// (get) Token: 0x06018B95 RID: 101269 RVA: 0x0038622C File Offset: 0x0038442C
		public IAccessQuestCondition? PreShowCondition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IAccessQuestCondition?(default(IAccessQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077E2 RID: 30690
		// (get) Token: 0x06018B96 RID: 101270 RVA: 0x0038628C File Offset: 0x0038448C
		public string TidPreShowDesc
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

		// Token: 0x06018B97 RID: 101271 RVA: 0x003862C3 File Offset: 0x003844C3
		public Span<byte> GetTidPreShowDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018B98 RID: 101272 RVA: 0x003862D2 File Offset: 0x003844D2
		public byte[] GetTidPreShowDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06018B99 RID: 101273 RVA: 0x003862E0 File Offset: 0x003844E0
		public static Offset<IPreShowInfo> CreateIPreShowInfo(FlatBufferBuilder builder, Offset<IAccessQuestCondition> PreShowConditionOffset = default(Offset<IAccessQuestCondition>), StringOffset TidPreShowDescOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPreShowInfo.AddTidPreShowDesc(builder, TidPreShowDescOffset);
			IPreShowInfo.AddPreShowCondition(builder, PreShowConditionOffset);
			return IPreShowInfo.EndIPreShowInfo(builder);
		}

		// Token: 0x06018B9A RID: 101274 RVA: 0x003862FD File Offset: 0x003844FD
		public static void StartIPreShowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018B9B RID: 101275 RVA: 0x00386306 File Offset: 0x00384506
		public static void AddPreShowCondition(FlatBufferBuilder builder, Offset<IAccessQuestCondition> preShowConditionOffset)
		{
			builder.AddOffset(0, preShowConditionOffset.Value, 0);
		}

		// Token: 0x06018B9C RID: 101276 RVA: 0x00386316 File Offset: 0x00384516
		public static void AddTidPreShowDesc(FlatBufferBuilder builder, StringOffset tidPreShowDescOffset)
		{
			builder.AddOffset(1, tidPreShowDescOffset.Value, 0);
		}

		// Token: 0x06018B9D RID: 101277 RVA: 0x00386326 File Offset: 0x00384526
		public static Offset<IPreShowInfo> EndIPreShowInfo(FlatBufferBuilder builder)
		{
			return new Offset<IPreShowInfo>(builder.EndTable());
		}

		// Token: 0x06018B9E RID: 101278 RVA: 0x00386334 File Offset: 0x00384534
		public IPreShowInfoT UnPack()
		{
			IPreShowInfoT preShowInfoT = new IPreShowInfoT();
			this.UnPackTo(preShowInfoT);
			return preShowInfoT;
		}

		// Token: 0x06018B9F RID: 101279 RVA: 0x00386350 File Offset: 0x00384550
		public void UnPackTo(IPreShowInfoT _o)
		{
			_o.PreShowCondition = ((this.PreShowCondition != null) ? this.PreShowCondition.Value.UnPack() : null);
			_o.TidPreShowDesc = this.TidPreShowDesc;
		}

		// Token: 0x06018BA0 RID: 101280 RVA: 0x00386398 File Offset: 0x00384598
		public static Offset<IPreShowInfo> Pack(FlatBufferBuilder builder, IPreShowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreShowInfo>);
			}
			Offset<IAccessQuestCondition> preShowConditionOffset = (_o.PreShowCondition == null) ? default(Offset<IAccessQuestCondition>) : IAccessQuestCondition.Pack(builder, _o.PreShowCondition);
			StringOffset tidPreShowDescOffset = (_o.TidPreShowDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidPreShowDesc);
			return IPreShowInfo.CreateIPreShowInfo(builder, preShowConditionOffset, tidPreShowDescOffset);
		}

		// Token: 0x0400C404 RID: 50180
		private Table __p;
	}
}
