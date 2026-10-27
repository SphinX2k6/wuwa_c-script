using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BF RID: 191
	[NetMessage(EMessageId.AdventureManualRequest)]
	public sealed class AdventureManualRequest : IMessage<AdventureManualRequest>, IMessage, IEquatable<AdventureManualRequest>, IDeepCloneable<AdventureManualRequest>, IBufferMessage
	{
		// Token: 0x06001EAA RID: 7850 RVA: 0x0005391B File Offset: 0x00051B1B
		[NullableContext(1)]
		public static AdventureManualRequest Create()
		{
			return new AdventureManualRequest();
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00053922 File Offset: 0x00051B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00053925 File Offset: 0x00051B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualRequest.Descriptor;
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0005392C File Offset: 0x00051B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualRequest()
		{
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00053934 File Offset: 0x00051B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualRequest(AdventureManualRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00053959 File Offset: 0x00051B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualRequest Clone()
		{
			return new AdventureManualRequest(this);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00053961 File Offset: 0x00051B61
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00053969 File Offset: 0x00051B69
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

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00053972 File Offset: 0x00051B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualRequest);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00053980 File Offset: 0x00051B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000539B0 File Offset: 0x00051BB0
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

		// Token: 0x06001EB5 RID: 7861 RVA: 0x000539EF File Offset: 0x00051BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000539FC File Offset: 0x00051BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00053A05 File Offset: 0x00051C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00053A38 File Offset: 0x00051C38
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

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00053A76 File Offset: 0x00051C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualRequest other)
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

		// Token: 0x06001EBA RID: 7866 RVA: 0x00053AA7 File Offset: 0x00051CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00053AB0 File Offset: 0x00051CB0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002372 RID: 9074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002373 RID: 9075
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04002374 RID: 9076
		private int playerId_;
	}
}
