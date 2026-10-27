using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000186 RID: 390
	[NetMessage(EMessageId.BeControlledDestroyRequest)]
	public sealed class BeControlledDestroyRequest : IMessage<BeControlledDestroyRequest>, IMessage, IEquatable<BeControlledDestroyRequest>, IDeepCloneable<BeControlledDestroyRequest>, IBufferMessage
	{
		// Token: 0x06002EFB RID: 12027 RVA: 0x00078A8A File Offset: 0x00076C8A
		[NullableContext(1)]
		public static BeControlledDestroyRequest Create()
		{
			return new BeControlledDestroyRequest();
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x00078A91 File Offset: 0x00076C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00078A94 File Offset: 0x00076C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledDestroyRequest.Descriptor;
			}
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00078A9B File Offset: 0x00076C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyRequest()
		{
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00078AA3 File Offset: 0x00076CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyRequest(BeControlledDestroyRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00078AC8 File Offset: 0x00076CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyRequest Clone()
		{
			return new BeControlledDestroyRequest(this);
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00078AD0 File Offset: 0x00076CD0
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x00078AD8 File Offset: 0x00076CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00078AE1 File Offset: 0x00076CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledDestroyRequest);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00078AEF File Offset: 0x00076CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledDestroyRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00078B20 File Offset: 0x00076D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00078B5F File Offset: 0x00076D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00078B6C File Offset: 0x00076D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00078B75 File Offset: 0x00076D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00078BA8 File Offset: 0x00076DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00078BE6 File Offset: 0x00076DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledDestroyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00078C17 File Offset: 0x00076E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00078C20 File Offset: 0x00076E20
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002896 RID: 10390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002897 RID: 10391
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04002898 RID: 10392
		private long entityId_;
	}
}
