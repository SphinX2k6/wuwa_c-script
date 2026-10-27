using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001167 RID: 4455
	public sealed class SceneItemLifeCycleComponentPb : IMessage<SceneItemLifeCycleComponentPb>, IMessage, IEquatable<SceneItemLifeCycleComponentPb>, IDeepCloneable<SceneItemLifeCycleComponentPb>, IBufferMessage
	{
		// Token: 0x06017C0D RID: 97293 RVA: 0x0037350C File Offset: 0x0037170C
		[NullableContext(1)]
		public static SceneItemLifeCycleComponentPb Create()
		{
			return new SceneItemLifeCycleComponentPb();
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x06017C0E RID: 97294 RVA: 0x00373513 File Offset: 0x00371713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x06017C0F RID: 97295 RVA: 0x00373516 File Offset: 0x00371716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemLifeCycleComponentPb.Descriptor;
			}
		}

		// Token: 0x06017C10 RID: 97296 RVA: 0x0037351D File Offset: 0x0037171D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb()
		{
		}

		// Token: 0x06017C11 RID: 97297 RVA: 0x00373525 File Offset: 0x00371725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb(SceneItemLifeCycleComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C12 RID: 97298 RVA: 0x0037354A File Offset: 0x0037174A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb Clone()
		{
			return new SceneItemLifeCycleComponentPb(this);
		}

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x06017C13 RID: 97299 RVA: 0x00373552 File Offset: 0x00371752
		// (set) Token: 0x06017C14 RID: 97300 RVA: 0x0037355A File Offset: 0x0037175A
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

		// Token: 0x06017C15 RID: 97301 RVA: 0x00373563 File Offset: 0x00371763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemLifeCycleComponentPb);
		}

		// Token: 0x06017C16 RID: 97302 RVA: 0x00373571 File Offset: 0x00371771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemLifeCycleComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C17 RID: 97303 RVA: 0x003735A0 File Offset: 0x003717A0
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

		// Token: 0x06017C18 RID: 97304 RVA: 0x003735DF File Offset: 0x003717DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C19 RID: 97305 RVA: 0x003735EC File Offset: 0x003717EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C1A RID: 97306 RVA: 0x003735F5 File Offset: 0x003717F5
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

		// Token: 0x06017C1B RID: 97307 RVA: 0x00373628 File Offset: 0x00371828
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

		// Token: 0x06017C1C RID: 97308 RVA: 0x00373666 File Offset: 0x00371866
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

		// Token: 0x06017C1D RID: 97309 RVA: 0x00373697 File Offset: 0x00371897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C1E RID: 97310 RVA: 0x003736A0 File Offset: 0x003718A0
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

		// Token: 0x04008CF6 RID: 36086
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CF7 RID: 36087
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04008CF8 RID: 36088
		private long contextId_;
	}
}
