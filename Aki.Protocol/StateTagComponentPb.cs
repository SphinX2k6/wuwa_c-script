using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001302 RID: 4866
	public sealed class StateTagComponentPb : IMessage<StateTagComponentPb>, IMessage, IEquatable<StateTagComponentPb>, IDeepCloneable<StateTagComponentPb>, IBufferMessage
	{
		// Token: 0x06019F4A RID: 106314 RVA: 0x003C8EEE File Offset: 0x003C70EE
		[NullableContext(1)]
		public static StateTagComponentPb Create()
		{
			return new StateTagComponentPb();
		}

		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x06019F4B RID: 106315 RVA: 0x003C8EF5 File Offset: 0x003C70F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x06019F4C RID: 106316 RVA: 0x003C8EF8 File Offset: 0x003C70F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateTagComponentPb.Descriptor;
			}
		}

		// Token: 0x06019F4D RID: 106317 RVA: 0x003C8EFF File Offset: 0x003C70FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb()
		{
		}

		// Token: 0x06019F4E RID: 106318 RVA: 0x003C8F07 File Offset: 0x003C7107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb(StateTagComponentPb other) : this()
		{
			this.stateTagId_ = other.stateTagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F4F RID: 106319 RVA: 0x003C8F2C File Offset: 0x003C712C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb Clone()
		{
			return new StateTagComponentPb(this);
		}

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x06019F50 RID: 106320 RVA: 0x003C8F34 File Offset: 0x003C7134
		// (set) Token: 0x06019F51 RID: 106321 RVA: 0x003C8F3C File Offset: 0x003C713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateTagId
		{
			get
			{
				return this.stateTagId_;
			}
			set
			{
				this.stateTagId_ = value;
			}
		}

		// Token: 0x06019F52 RID: 106322 RVA: 0x003C8F45 File Offset: 0x003C7145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateTagComponentPb);
		}

		// Token: 0x06019F53 RID: 106323 RVA: 0x003C8F53 File Offset: 0x003C7153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StateTagComponentPb other)
		{
			return other != null && (other == this || (this.StateTagId == other.StateTagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F54 RID: 106324 RVA: 0x003C8F84 File Offset: 0x003C7184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StateTagId != 0)
			{
				num ^= this.StateTagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F55 RID: 106325 RVA: 0x003C8FC3 File Offset: 0x003C71C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F56 RID: 106326 RVA: 0x003C8FD0 File Offset: 0x003C71D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F57 RID: 106327 RVA: 0x003C8FD9 File Offset: 0x003C71D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StateTagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F58 RID: 106328 RVA: 0x003C900C File Offset: 0x003C720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StateTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F59 RID: 106329 RVA: 0x003C904A File Offset: 0x003C724A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StateTagComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StateTagId != 0)
			{
				this.StateTagId = other.StateTagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F5A RID: 106330 RVA: 0x003C907B File Offset: 0x003C727B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F5B RID: 106331 RVA: 0x003C9084 File Offset: 0x003C7284
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
					this.StateTagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098FA RID: 39162
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098FB RID: 39163
		public const int StateTagIdFieldNumber = 1;

		// Token: 0x040098FC RID: 39164
		private int stateTagId_;
	}
}
