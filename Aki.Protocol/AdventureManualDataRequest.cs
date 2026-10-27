using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BD RID: 189
	[NetMessage(EMessageId.AdventureManualDataRequest)]
	public sealed class AdventureManualDataRequest : IMessage<AdventureManualDataRequest>, IMessage, IEquatable<AdventureManualDataRequest>, IDeepCloneable<AdventureManualDataRequest>, IBufferMessage
	{
		// Token: 0x06001E84 RID: 7812 RVA: 0x0005344C File Offset: 0x0005164C
		[NullableContext(1)]
		public static AdventureManualDataRequest Create()
		{
			return new AdventureManualDataRequest();
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00053453 File Offset: 0x00051653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00053456 File Offset: 0x00051656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualDataRequest.Descriptor;
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0005345D File Offset: 0x0005165D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataRequest()
		{
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00053465 File Offset: 0x00051665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataRequest(AdventureManualDataRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0005348A File Offset: 0x0005168A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataRequest Clone()
		{
			return new AdventureManualDataRequest(this);
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00053492 File Offset: 0x00051692
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0005349A File Offset: 0x0005169A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000534A3 File Offset: 0x000516A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualDataRequest);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x000534B1 File Offset: 0x000516B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualDataRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000534E0 File Offset: 0x000516E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0005351F File Offset: 0x0005171F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0005352C File Offset: 0x0005172C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00053535 File Offset: 0x00051735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00053568 File Offset: 0x00051768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000535A6 File Offset: 0x000517A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000535D7 File Offset: 0x000517D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000535E0 File Offset: 0x000517E0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400236A RID: 9066
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400236B RID: 9067
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x0400236C RID: 9068
		private int playerId_;
	}
}
