using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000800 RID: 2048
	[NetMessage(EMessageId.InfrV2ManualSwitchTraceTreeRequest)]
	public sealed class InfrV2ManualSwitchTraceTreeRequest : IMessage<InfrV2ManualSwitchTraceTreeRequest>, IMessage, IEquatable<InfrV2ManualSwitchTraceTreeRequest>, IDeepCloneable<InfrV2ManualSwitchTraceTreeRequest>, IBufferMessage
	{
		// Token: 0x0600B75E RID: 46942 RVA: 0x001B52AD File Offset: 0x001B34AD
		[NullableContext(1)]
		public static InfrV2ManualSwitchTraceTreeRequest Create()
		{
			return new InfrV2ManualSwitchTraceTreeRequest();
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x0600B75F RID: 46943 RVA: 0x001B52B4 File Offset: 0x001B34B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x001B52B7 File Offset: 0x001B34B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualSwitchTraceTreeRequest.Descriptor;
			}
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x001B52BE File Offset: 0x001B34BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeRequest()
		{
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x001B52C6 File Offset: 0x001B34C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeRequest(InfrV2ManualSwitchTraceTreeRequest other) : this()
		{
			this.treeId_ = other.treeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x001B52EB File Offset: 0x001B34EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualSwitchTraceTreeRequest Clone()
		{
			return new InfrV2ManualSwitchTraceTreeRequest(this);
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x001B52F3 File Offset: 0x001B34F3
		// (set) Token: 0x0600B765 RID: 46949 RVA: 0x001B52FB File Offset: 0x001B34FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x001B5304 File Offset: 0x001B3504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualSwitchTraceTreeRequest);
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x001B5312 File Offset: 0x001B3512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualSwitchTraceTreeRequest other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x001B5340 File Offset: 0x001B3540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x001B537F File Offset: 0x001B357F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x001B538C File Offset: 0x001B358C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x001B5395 File Offset: 0x001B3595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x001B53C8 File Offset: 0x001B35C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x001B5406 File Offset: 0x001B3606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualSwitchTraceTreeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x001B5437 File Offset: 0x001B3637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x001B5440 File Offset: 0x001B3640
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040050F7 RID: 20727
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050F8 RID: 20728
		public const int TreeIdFieldNumber = 7;

		// Token: 0x040050F9 RID: 20729
		private int treeId_;
	}
}
