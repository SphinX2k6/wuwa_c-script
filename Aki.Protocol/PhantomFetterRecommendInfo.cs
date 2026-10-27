using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD1 RID: 3281
	public sealed class PhantomFetterRecommendInfo : IMessage<PhantomFetterRecommendInfo>, IMessage, IEquatable<PhantomFetterRecommendInfo>, IDeepCloneable<PhantomFetterRecommendInfo>, IBufferMessage
	{
		// Token: 0x06011C24 RID: 72740 RVA: 0x00299317 File Offset: 0x00297517
		[NullableContext(1)]
		public static PhantomFetterRecommendInfo Create()
		{
			return new PhantomFetterRecommendInfo();
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x06011C25 RID: 72741 RVA: 0x0029931E File Offset: 0x0029751E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomFetterRecommendInfo> Parser
		{
			get
			{
				return PhantomFetterRecommendInfo._parser;
			}
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x06011C26 RID: 72742 RVA: 0x00299325 File Offset: 0x00297525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x06011C27 RID: 72743 RVA: 0x00299328 File Offset: 0x00297528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06011C28 RID: 72744 RVA: 0x0029932F File Offset: 0x0029752F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendInfo()
		{
		}

		// Token: 0x06011C29 RID: 72745 RVA: 0x00299358 File Offset: 0x00297558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendInfo(PhantomFetterRecommendInfo other) : this()
		{
			this.usage_ = other.usage_;
			this.phantomFetterGroupInfos_ = other.phantomFetterGroupInfos_.Clone();
			this.costCombinationInfos_ = other.costCombinationInfos_.Clone();
			this.mainPhantomRecommendInfos_ = other.mainPhantomRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C2A RID: 72746 RVA: 0x002993BB File Offset: 0x002975BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendInfo Clone()
		{
			return new PhantomFetterRecommendInfo(this);
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x06011C2B RID: 72747 RVA: 0x002993C3 File Offset: 0x002975C3
		// (set) Token: 0x06011C2C RID: 72748 RVA: 0x002993CB File Offset: 0x002975CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x06011C2D RID: 72749 RVA: 0x002993D4 File Offset: 0x002975D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomFetterGroupInfo> PhantomFetterGroupInfos
		{
			get
			{
				return this.phantomFetterGroupInfos_;
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x06011C2E RID: 72750 RVA: 0x002993DC File Offset: 0x002975DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CostCombinationInfo> CostCombinationInfos
		{
			get
			{
				return this.costCombinationInfos_;
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x06011C2F RID: 72751 RVA: 0x002993E4 File Offset: 0x002975E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainPhantomRecommendInfo> MainPhantomRecommendInfos
		{
			get
			{
				return this.mainPhantomRecommendInfos_;
			}
		}

		// Token: 0x06011C30 RID: 72752 RVA: 0x002993EC File Offset: 0x002975EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterRecommendInfo);
		}

		// Token: 0x06011C31 RID: 72753 RVA: 0x002993FC File Offset: 0x002975FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterRecommendInfo other)
		{
			return other != null && (other == this || (this.Usage == other.Usage && this.phantomFetterGroupInfos_.Equals(other.phantomFetterGroupInfos_) && this.costCombinationInfos_.Equals(other.costCombinationInfos_) && this.mainPhantomRecommendInfos_.Equals(other.mainPhantomRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C32 RID: 72754 RVA: 0x00299474 File Offset: 0x00297674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			num ^= this.phantomFetterGroupInfos_.GetHashCode();
			num ^= this.costCombinationInfos_.GetHashCode();
			num ^= this.mainPhantomRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C33 RID: 72755 RVA: 0x002994DD File Offset: 0x002976DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C34 RID: 72756 RVA: 0x002994EA File Offset: 0x002976EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C35 RID: 72757 RVA: 0x002994F4 File Offset: 0x002976F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Usage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Usage);
			}
			this.phantomFetterGroupInfos_.WriteTo(ref output, PhantomFetterRecommendInfo._repeated_phantomFetterGroupInfos_codec);
			this.costCombinationInfos_.WriteTo(ref output, PhantomFetterRecommendInfo._repeated_costCombinationInfos_codec);
			this.mainPhantomRecommendInfos_.WriteTo(ref output, PhantomFetterRecommendInfo._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C36 RID: 72758 RVA: 0x00299564 File Offset: 0x00297764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			num += this.phantomFetterGroupInfos_.CalculateSize(PhantomFetterRecommendInfo._repeated_phantomFetterGroupInfos_codec);
			num += this.costCombinationInfos_.CalculateSize(PhantomFetterRecommendInfo._repeated_costCombinationInfos_codec);
			num += this.mainPhantomRecommendInfos_.CalculateSize(PhantomFetterRecommendInfo._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C37 RID: 72759 RVA: 0x002995DC File Offset: 0x002977DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			this.phantomFetterGroupInfos_.Add(other.phantomFetterGroupInfos_);
			this.costCombinationInfos_.Add(other.costCombinationInfos_);
			this.mainPhantomRecommendInfos_.Add(other.mainPhantomRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C38 RID: 72760 RVA: 0x0029964B File Offset: 0x0029784B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C39 RID: 72761 RVA: 0x00299654 File Offset: 0x00297854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 26U)
				{
					if (num == 16U)
					{
						this.Usage = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.phantomFetterGroupInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendInfo._repeated_phantomFetterGroupInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.costCombinationInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendInfo._repeated_costCombinationInfos_codec);
						continue;
					}
					if (num == 42U)
					{
						this.mainPhantomRecommendInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendInfo._repeated_mainPhantomRecommendInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006F92 RID: 28562
		private static readonly MessageParser<PhantomFetterRecommendInfo> _parser = new MessageParser<PhantomFetterRecommendInfo>(() => new PhantomFetterRecommendInfo());

		// Token: 0x04006F93 RID: 28563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F94 RID: 28564
		public const int UsageFieldNumber = 2;

		// Token: 0x04006F95 RID: 28565
		private int usage_;

		// Token: 0x04006F96 RID: 28566
		public const int PhantomFetterGroupInfosFieldNumber = 3;

		// Token: 0x04006F97 RID: 28567
		private static readonly FieldCodec<PhantomFetterGroupInfo> _repeated_phantomFetterGroupInfos_codec = FieldCodec.ForMessage<PhantomFetterGroupInfo>(26U, PhantomFetterGroupInfo.Parser);

		// Token: 0x04006F98 RID: 28568
		private readonly RepeatedField<PhantomFetterGroupInfo> phantomFetterGroupInfos_ = new RepeatedField<PhantomFetterGroupInfo>();

		// Token: 0x04006F99 RID: 28569
		public const int CostCombinationInfosFieldNumber = 4;

		// Token: 0x04006F9A RID: 28570
		private static readonly FieldCodec<CostCombinationInfo> _repeated_costCombinationInfos_codec = FieldCodec.ForMessage<CostCombinationInfo>(34U, CostCombinationInfo.Parser);

		// Token: 0x04006F9B RID: 28571
		private readonly RepeatedField<CostCombinationInfo> costCombinationInfos_ = new RepeatedField<CostCombinationInfo>();

		// Token: 0x04006F9C RID: 28572
		public const int MainPhantomRecommendInfosFieldNumber = 5;

		// Token: 0x04006F9D RID: 28573
		private static readonly FieldCodec<MainPhantomRecommendInfo> _repeated_mainPhantomRecommendInfos_codec = FieldCodec.ForMessage<MainPhantomRecommendInfo>(42U, MainPhantomRecommendInfo.Parser);

		// Token: 0x04006F9E RID: 28574
		private readonly RepeatedField<MainPhantomRecommendInfo> mainPhantomRecommendInfos_ = new RepeatedField<MainPhantomRecommendInfo>();
	}
}
