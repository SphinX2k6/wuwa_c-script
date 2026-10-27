using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000258 RID: 600
	[NetMessage(EMessageId.ChangePlayerTitleRequest)]
	public sealed class ChangePlayerTitleRequest : IMessage<ChangePlayerTitleRequest>, IMessage, IEquatable<ChangePlayerTitleRequest>, IDeepCloneable<ChangePlayerTitleRequest>, IBufferMessage
	{
		// Token: 0x06003FBF RID: 16319 RVA: 0x0009CC4B File Offset: 0x0009AE4B
		[NullableContext(1)]
		public static ChangePlayerTitleRequest Create()
		{
			return new ChangePlayerTitleRequest();
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x0009CC52 File Offset: 0x0009AE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x0009CC55 File Offset: 0x0009AE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePlayerTitleRequest.Descriptor;
			}
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x0009CC5C File Offset: 0x0009AE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleRequest()
		{
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x0009CC64 File Offset: 0x0009AE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleRequest(ChangePlayerTitleRequest other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x0009CC89 File Offset: 0x0009AE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerTitleRequest Clone()
		{
			return new ChangePlayerTitleRequest(this);
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x0009CC91 File Offset: 0x0009AE91
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x0009CC99 File Offset: 0x0009AE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x0009CCA2 File Offset: 0x0009AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePlayerTitleRequest);
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x0009CCB0 File Offset: 0x0009AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePlayerTitleRequest other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0009CCE0 File Offset: 0x0009AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x0009CD1F File Offset: 0x0009AF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x0009CD2C File Offset: 0x0009AF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x0009CD35 File Offset: 0x0009AF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x0009CD68 File Offset: 0x0009AF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0009CDA6 File Offset: 0x0009AFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePlayerTitleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x0009CDD7 File Offset: 0x0009AFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x0009CDE0 File Offset: 0x0009AFE0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerTitleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D36 RID: 11574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D37 RID: 11575
		public const int PlayerTitleIdFieldNumber = 6;

		// Token: 0x04002D38 RID: 11576
		private int playerTitleId_;
	}
}
