using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5E RID: 3934
	public sealed class RiskHarvestInstBuffInfo : IMessage<RiskHarvestInstBuffInfo>, IMessage, IEquatable<RiskHarvestInstBuffInfo>, IDeepCloneable<RiskHarvestInstBuffInfo>, IBufferMessage
	{
		// Token: 0x060150A3 RID: 86179 RVA: 0x0030D48E File Offset: 0x0030B68E
		[NullableContext(1)]
		public static RiskHarvestInstBuffInfo Create()
		{
			return new RiskHarvestInstBuffInfo();
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x060150A4 RID: 86180 RVA: 0x0030D495 File Offset: 0x0030B695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RiskHarvestInstBuffInfo> Parser
		{
			get
			{
				return RiskHarvestInstBuffInfo._parser;
			}
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x060150A5 RID: 86181 RVA: 0x0030D49C File Offset: 0x0030B69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x060150A6 RID: 86182 RVA: 0x0030D49F File Offset: 0x0030B69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstBuffInfo.Descriptor;
			}
		}

		// Token: 0x060150A7 RID: 86183 RVA: 0x0030D4A6 File Offset: 0x0030B6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstBuffInfo()
		{
		}

		// Token: 0x060150A8 RID: 86184 RVA: 0x0030D4AE File Offset: 0x0030B6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstBuffInfo(RiskHarvestInstBuffInfo other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060150A9 RID: 86185 RVA: 0x0030D4DF File Offset: 0x0030B6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstBuffInfo Clone()
		{
			return new RiskHarvestInstBuffInfo(this);
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x060150AA RID: 86186 RVA: 0x0030D4E7 File Offset: 0x0030B6E7
		// (set) Token: 0x060150AB RID: 86187 RVA: 0x0030D4EF File Offset: 0x0030B6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x060150AC RID: 86188 RVA: 0x0030D4F8 File Offset: 0x0030B6F8
		// (set) Token: 0x060150AD RID: 86189 RVA: 0x0030D500 File Offset: 0x0030B700
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

		// Token: 0x060150AE RID: 86190 RVA: 0x0030D509 File Offset: 0x0030B709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstBuffInfo);
		}

		// Token: 0x060150AF RID: 86191 RVA: 0x0030D517 File Offset: 0x0030B717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstBuffInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150B0 RID: 86192 RVA: 0x0030D558 File Offset: 0x0030B758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x060150B1 RID: 86193 RVA: 0x0030D5B0 File Offset: 0x0030B7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150B2 RID: 86194 RVA: 0x0030D5BD File Offset: 0x0030B7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150B3 RID: 86195 RVA: 0x0030D5C8 File Offset: 0x0030B7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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

		// Token: 0x060150B4 RID: 86196 RVA: 0x0030D620 File Offset: 0x0030B820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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

		// Token: 0x060150B5 RID: 86197 RVA: 0x0030D678 File Offset: 0x0030B878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060150B6 RID: 86198 RVA: 0x0030D6C8 File Offset: 0x0030B8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150B7 RID: 86199 RVA: 0x0030D6D4 File Offset: 0x0030B8D4
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007EC1 RID: 32449
		private static readonly MessageParser<RiskHarvestInstBuffInfo> _parser = new MessageParser<RiskHarvestInstBuffInfo>(() => new RiskHarvestInstBuffInfo());

		// Token: 0x04007EC2 RID: 32450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EC3 RID: 32451
		public const int IdFieldNumber = 1;

		// Token: 0x04007EC4 RID: 32452
		private int id_;

		// Token: 0x04007EC5 RID: 32453
		public const int CountFieldNumber = 2;

		// Token: 0x04007EC6 RID: 32454
		private int count_;
	}
}
