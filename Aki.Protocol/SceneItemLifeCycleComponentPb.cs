using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A1 RID: 4513
	public sealed class SceneItemLifeCycleComponentPb : IMessage<SceneItemLifeCycleComponentPb>, IMessage, IEquatable<SceneItemLifeCycleComponentPb>, IDeepCloneable<SceneItemLifeCycleComponentPb>, IBufferMessage
	{
		// Token: 0x060181AE RID: 98734 RVA: 0x0038285C File Offset: 0x00380A5C
		[NullableContext(1)]
		public static SceneItemLifeCycleComponentPb Create()
		{
			return new SceneItemLifeCycleComponentPb();
		}

		// Token: 0x17005137 RID: 20791
		// (get) Token: 0x060181AF RID: 98735 RVA: 0x00382863 File Offset: 0x00380A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005138 RID: 20792
		// (get) Token: 0x060181B0 RID: 98736 RVA: 0x00382866 File Offset: 0x00380A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemLifeCycleComponentPb.Descriptor;
			}
		}

		// Token: 0x060181B1 RID: 98737 RVA: 0x0038286D File Offset: 0x00380A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb()
		{
		}

		// Token: 0x060181B2 RID: 98738 RVA: 0x00382875 File Offset: 0x00380A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb(SceneItemLifeCycleComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060181B3 RID: 98739 RVA: 0x0038289A File Offset: 0x00380A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb Clone()
		{
			return new SceneItemLifeCycleComponentPb(this);
		}

		// Token: 0x17005139 RID: 20793
		// (get) Token: 0x060181B4 RID: 98740 RVA: 0x003828A2 File Offset: 0x00380AA2
		// (set) Token: 0x060181B5 RID: 98741 RVA: 0x003828AA File Offset: 0x00380AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x060181B6 RID: 98742 RVA: 0x003828B3 File Offset: 0x00380AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemLifeCycleComponentPb);
		}

		// Token: 0x060181B7 RID: 98743 RVA: 0x003828C1 File Offset: 0x00380AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemLifeCycleComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181B8 RID: 98744 RVA: 0x003828F0 File Offset: 0x00380AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060181B9 RID: 98745 RVA: 0x0038292F File Offset: 0x00380B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181BA RID: 98746 RVA: 0x0038293C File Offset: 0x00380B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181BB RID: 98747 RVA: 0x00382945 File Offset: 0x00380B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060181BC RID: 98748 RVA: 0x00382978 File Offset: 0x00380B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060181BD RID: 98749 RVA: 0x003829B6 File Offset: 0x00380BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemLifeCycleComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060181BE RID: 98750 RVA: 0x003829E7 File Offset: 0x00380BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181BF RID: 98751 RVA: 0x003829F0 File Offset: 0x00380BF0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008F89 RID: 36745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F8A RID: 36746
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04008F8B RID: 36747
		private long contextId_;
	}
}
