using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080C RID: 2060
	public sealed class InfrV2TreePb : IMessage<InfrV2TreePb>, IMessage, IEquatable<InfrV2TreePb>, IDeepCloneable<InfrV2TreePb>, IBufferMessage
	{
		// Token: 0x0600B846 RID: 47174 RVA: 0x001B6F99 File Offset: 0x001B5199
		[NullableContext(1)]
		public static InfrV2TreePb Create()
		{
			return new InfrV2TreePb();
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600B847 RID: 47175 RVA: 0x001B6FA0 File Offset: 0x001B51A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x001B6FA3 File Offset: 0x001B51A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreePb.Descriptor;
			}
		}

		// Token: 0x0600B849 RID: 47177 RVA: 0x001B6FAA File Offset: 0x001B51AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb()
		{
		}

		// Token: 0x0600B84A RID: 47178 RVA: 0x001B6FBD File Offset: 0x001B51BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb(InfrV2TreePb other) : this()
		{
			this.trees_ = other.trees_.Clone();
			this.manualTraceTree_ = other.manualTraceTree_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x001B6FF3 File Offset: 0x001B51F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb Clone()
		{
			return new InfrV2TreePb(this);
		}

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x0600B84C RID: 47180 RVA: 0x001B6FFB File Offset: 0x001B51FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrV2OneTree> Trees
		{
			get
			{
				return this.trees_;
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x0600B84D RID: 47181 RVA: 0x001B7003 File Offset: 0x001B5203
		// (set) Token: 0x0600B84E RID: 47182 RVA: 0x001B700B File Offset: 0x001B520B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ManualTraceTree
		{
			get
			{
				return this.manualTraceTree_;
			}
			set
			{
				this.manualTraceTree_ = value;
			}
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x001B7014 File Offset: 0x001B5214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreePb);
		}

		// Token: 0x0600B850 RID: 47184 RVA: 0x001B7024 File Offset: 0x001B5224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreePb other)
		{
			return other != null && (other == this || (this.trees_.Equals(other.trees_) && this.ManualTraceTree == other.ManualTraceTree && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B851 RID: 47185 RVA: 0x001B7074 File Offset: 0x001B5274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trees_.GetHashCode();
			if (this.ManualTraceTree != 0)
			{
				num ^= this.ManualTraceTree.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B852 RID: 47186 RVA: 0x001B70C1 File Offset: 0x001B52C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x001B70CE File Offset: 0x001B52CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x001B70D8 File Offset: 0x001B52D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trees_.WriteTo(ref output, InfrV2TreePb._repeated_trees_codec);
			if (this.ManualTraceTree != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ManualTraceTree);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x001B7128 File Offset: 0x001B5328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trees_.CalculateSize(InfrV2TreePb._repeated_trees_codec);
			if (this.ManualTraceTree != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ManualTraceTree);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x001B717C File Offset: 0x001B537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreePb other)
		{
			if (other == null)
			{
				return;
			}
			this.trees_.Add(other.trees_);
			if (other.ManualTraceTree != 0)
			{
				this.ManualTraceTree = other.ManualTraceTree;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B857 RID: 47191 RVA: 0x001B71C9 File Offset: 0x001B53C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B858 RID: 47192 RVA: 0x001B71D4 File Offset: 0x001B53D4
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
				if (num != 10U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ManualTraceTree = input.ReadInt32();
					}
				}
				else
				{
					this.trees_.AddEntriesFrom(ref input, InfrV2TreePb._repeated_trees_codec);
				}
			}
		}

		// Token: 0x04005132 RID: 20786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005133 RID: 20787
		public const int TreesFieldNumber = 1;

		// Token: 0x04005134 RID: 20788
		private static readonly FieldCodec<InfrV2OneTree> _repeated_trees_codec = FieldCodec.ForMessage<InfrV2OneTree>(10U, InfrV2OneTree.Parser);

		// Token: 0x04005135 RID: 20789
		private readonly RepeatedField<InfrV2OneTree> trees_ = new RepeatedField<InfrV2OneTree>();

		// Token: 0x04005136 RID: 20790
		public const int ManualTraceTreeFieldNumber = 3;

		// Token: 0x04005137 RID: 20791
		private int manualTraceTree_;
	}
}
