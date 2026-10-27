using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F28 RID: 3880
	public sealed class ResonantChainOptionalLimitInfo : IMessage<ResonantChainOptionalLimitInfo>, IMessage, IEquatable<ResonantChainOptionalLimitInfo>, IDeepCloneable<ResonantChainOptionalLimitInfo>, IBufferMessage
	{
		// Token: 0x06014C32 RID: 85042 RVA: 0x00303335 File Offset: 0x00301535
		[NullableContext(1)]
		public static ResonantChainOptionalLimitInfo Create()
		{
			return new ResonantChainOptionalLimitInfo();
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x06014C33 RID: 85043 RVA: 0x0030333C File Offset: 0x0030153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ResonantChainOptionalLimitInfo> Parser
		{
			get
			{
				return ResonantChainOptionalLimitInfo._parser;
			}
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x06014C34 RID: 85044 RVA: 0x00303343 File Offset: 0x00301543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x06014C35 RID: 85045 RVA: 0x00303346 File Offset: 0x00301546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainOptionalLimitInfo.Descriptor;
			}
		}

		// Token: 0x06014C36 RID: 85046 RVA: 0x0030334D File Offset: 0x0030154D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitInfo()
		{
		}

		// Token: 0x06014C37 RID: 85047 RVA: 0x00303355 File Offset: 0x00301555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitInfo(ResonantChainOptionalLimitInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C38 RID: 85048 RVA: 0x00303386 File Offset: 0x00301586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitInfo Clone()
		{
			return new ResonantChainOptionalLimitInfo(this);
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x06014C39 RID: 85049 RVA: 0x0030338E File Offset: 0x0030158E
		// (set) Token: 0x06014C3A RID: 85050 RVA: 0x00303396 File Offset: 0x00301596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x06014C3B RID: 85051 RVA: 0x0030339F File Offset: 0x0030159F
		// (set) Token: 0x06014C3C RID: 85052 RVA: 0x003033A7 File Offset: 0x003015A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06014C3D RID: 85053 RVA: 0x003033B0 File Offset: 0x003015B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainOptionalLimitInfo);
		}

		// Token: 0x06014C3E RID: 85054 RVA: 0x003033BE File Offset: 0x003015BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainOptionalLimitInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C3F RID: 85055 RVA: 0x003033FC File Offset: 0x003015FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C40 RID: 85056 RVA: 0x00303454 File Offset: 0x00301654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C41 RID: 85057 RVA: 0x00303461 File Offset: 0x00301661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C42 RID: 85058 RVA: 0x0030346C File Offset: 0x0030166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C43 RID: 85059 RVA: 0x003034C4 File Offset: 0x003016C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C44 RID: 85060 RVA: 0x0030351C File Offset: 0x0030171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainOptionalLimitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C45 RID: 85061 RVA: 0x0030356C File Offset: 0x0030176C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C46 RID: 85062 RVA: 0x00303578 File Offset: 0x00301778
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D5A RID: 32090
		private static readonly MessageParser<ResonantChainOptionalLimitInfo> _parser = new MessageParser<ResonantChainOptionalLimitInfo>(() => new ResonantChainOptionalLimitInfo());

		// Token: 0x04007D5B RID: 32091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D5C RID: 32092
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04007D5D RID: 32093
		private int itemId_;

		// Token: 0x04007D5E RID: 32094
		public const int CountFieldNumber = 2;

		// Token: 0x04007D5F RID: 32095
		private int count_;
	}
}
