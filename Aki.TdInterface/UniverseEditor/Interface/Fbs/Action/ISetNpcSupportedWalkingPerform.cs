using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780C RID: 30732
	public struct ISetNpcSupportedWalkingPerform : IFlatbufferObject
	{
		// Token: 0x1700E147 RID: 57671
		// (get) Token: 0x06036009 RID: 221193 RVA: 0x0073BD22 File Offset: 0x00739F22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603600A RID: 221194 RVA: 0x0073BD2F File Offset: 0x00739F2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603600B RID: 221195 RVA: 0x0073BD38 File Offset: 0x00739F38
		public static ISetNpcSupportedWalkingPerform GetRootAsISetNpcSupportedWalkingPerform(ByteBuffer _bb)
		{
			return ISetNpcSupportedWalkingPerform.GetRootAsISetNpcSupportedWalkingPerform(_bb, default(ISetNpcSupportedWalkingPerform));
		}

		// Token: 0x0603600C RID: 221196 RVA: 0x0073BD54 File Offset: 0x00739F54
		public static ISetNpcSupportedWalkingPerform GetRootAsISetNpcSupportedWalkingPerform(ByteBuffer _bb, ISetNpcSupportedWalkingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603600D RID: 221197 RVA: 0x0073BD71 File Offset: 0x00739F71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603600E RID: 221198 RVA: 0x0073BD80 File Offset: 0x00739F80
		public ISetNpcSupportedWalkingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E148 RID: 57672
		// (get) Token: 0x0603600F RID: 221199 RVA: 0x0073BD90 File Offset: 0x00739F90
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E149 RID: 57673
		// (get) Token: 0x06036010 RID: 221200 RVA: 0x0073BDCC File Offset: 0x00739FCC
		public IPlayerInitiator? Initiator
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayerInitiator?(default(IPlayerInitiator).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E14A RID: 57674
		// (get) Token: 0x06036011 RID: 221201 RVA: 0x0073BE2C File Offset: 0x0073A02C
		public int Target
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036012 RID: 221202 RVA: 0x0073BE68 File Offset: 0x0073A068
		public static Offset<ISetNpcSupportedWalkingPerform> CreateISetNpcSupportedWalkingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, Offset<IPlayerInitiator> InitiatorOffset = default(Offset<IPlayerInitiator>), int Target = 0)
		{
			builder.StartTable(3);
			ISetNpcSupportedWalkingPerform.AddTarget(builder, Target);
			ISetNpcSupportedWalkingPerform.AddInitiator(builder, InitiatorOffset);
			ISetNpcSupportedWalkingPerform.AddType(builder, Type);
			return ISetNpcSupportedWalkingPerform.EndISetNpcSupportedWalkingPerform(builder);
		}

		// Token: 0x06036013 RID: 221203 RVA: 0x0073BE8C File Offset: 0x0073A08C
		public static void StartISetNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036014 RID: 221204 RVA: 0x0073BE95 File Offset: 0x0073A095
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036015 RID: 221205 RVA: 0x0073BEA0 File Offset: 0x0073A0A0
		public static void AddInitiator(FlatBufferBuilder builder, Offset<IPlayerInitiator> initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset.Value, 0);
		}

		// Token: 0x06036016 RID: 221206 RVA: 0x0073BEB0 File Offset: 0x0073A0B0
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(2, target, 0);
		}

		// Token: 0x06036017 RID: 221207 RVA: 0x0073BEBB File Offset: 0x0073A0BB
		public static Offset<ISetNpcSupportedWalkingPerform> EndISetNpcSupportedWalkingPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcSupportedWalkingPerform>(builder.EndTable());
		}

		// Token: 0x06036018 RID: 221208 RVA: 0x0073BEC8 File Offset: 0x0073A0C8
		public ISetNpcSupportedWalkingPerformT UnPack()
		{
			ISetNpcSupportedWalkingPerformT setNpcSupportedWalkingPerformT = new ISetNpcSupportedWalkingPerformT();
			this.UnPackTo(setNpcSupportedWalkingPerformT);
			return setNpcSupportedWalkingPerformT;
		}

		// Token: 0x06036019 RID: 221209 RVA: 0x0073BEE4 File Offset: 0x0073A0E4
		public void UnPackTo(ISetNpcSupportedWalkingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Initiator = ((this.Initiator != null) ? this.Initiator.Value.UnPack() : null);
			_o.Target = this.Target;
		}

		// Token: 0x0603601A RID: 221210 RVA: 0x0073BF38 File Offset: 0x0073A138
		public static Offset<ISetNpcSupportedWalkingPerform> Pack(FlatBufferBuilder builder, ISetNpcSupportedWalkingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcSupportedWalkingPerform>);
			}
			Offset<IPlayerInitiator> initiatorOffset = (_o.Initiator == null) ? default(Offset<IPlayerInitiator>) : IPlayerInitiator.Pack(builder, _o.Initiator);
			return ISetNpcSupportedWalkingPerform.CreateISetNpcSupportedWalkingPerform(builder, _o.Type, initiatorOffset, _o.Target);
		}

		// Token: 0x04012A69 RID: 76393
		private Table __p;
	}
}
