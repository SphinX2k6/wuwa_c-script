using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B94 RID: 2964
	[NetMessage(EMessageId.OperationRestrictionNotify)]
	public sealed class OperationRestrictionNotify : IMessage<OperationRestrictionNotify>, IMessage, IEquatable<OperationRestrictionNotify>, IDeepCloneable<OperationRestrictionNotify>, IBufferMessage
	{
		// Token: 0x06010184 RID: 65924 RVA: 0x00259EBD File Offset: 0x002580BD
		[NullableContext(1)]
		public static OperationRestrictionNotify Create()
		{
			return new OperationRestrictionNotify();
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x06010185 RID: 65925 RVA: 0x00259EC4 File Offset: 0x002580C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x06010186 RID: 65926 RVA: 0x00259EC7 File Offset: 0x002580C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OperationRestrictionNotify.Descriptor;
			}
		}

		// Token: 0x06010187 RID: 65927 RVA: 0x00259ECE File Offset: 0x002580CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OperationRestrictionNotify()
		{
		}

		// Token: 0x06010188 RID: 65928 RVA: 0x00259EE1 File Offset: 0x002580E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OperationRestrictionNotify(OperationRestrictionNotify other) : this()
		{
			this.params_ = other.params_;
			this.isNull_ = other.isNull_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010189 RID: 65929 RVA: 0x00259F12 File Offset: 0x00258112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OperationRestrictionNotify Clone()
		{
			return new OperationRestrictionNotify(this);
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0601018A RID: 65930 RVA: 0x00259F1A File Offset: 0x0025811A
		// (set) Token: 0x0601018B RID: 65931 RVA: 0x00259F22 File Offset: 0x00258122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0601018C RID: 65932 RVA: 0x00259F35 File Offset: 0x00258135
		// (set) Token: 0x0601018D RID: 65933 RVA: 0x00259F3D File Offset: 0x0025813D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNull
		{
			get
			{
				return this.isNull_;
			}
			set
			{
				this.isNull_ = value;
			}
		}

		// Token: 0x0601018E RID: 65934 RVA: 0x00259F46 File Offset: 0x00258146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OperationRestrictionNotify);
		}

		// Token: 0x0601018F RID: 65935 RVA: 0x00259F54 File Offset: 0x00258154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OperationRestrictionNotify other)
		{
			return other != null && (other == this || (!(this.Params != other.Params) && this.IsNull == other.IsNull && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010190 RID: 65936 RVA: 0x00259FA4 File Offset: 0x002581A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Params.Length != 0)
			{
				num ^= this.Params.GetHashCode();
			}
			if (this.IsNull)
			{
				num ^= this.IsNull.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010191 RID: 65937 RVA: 0x00259FFE File Offset: 0x002581FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010192 RID: 65938 RVA: 0x0025A00B File Offset: 0x0025820B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010193 RID: 65939 RVA: 0x0025A014 File Offset: 0x00258214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNull)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsNull);
			}
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Params);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010194 RID: 65940 RVA: 0x0025A074 File Offset: 0x00258274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Params.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Params);
			}
			if (this.IsNull)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010195 RID: 65941 RVA: 0x0025A0C4 File Offset: 0x002582C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OperationRestrictionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Params.Length != 0)
			{
				this.Params = other.Params;
			}
			if (other.IsNull)
			{
				this.IsNull = other.IsNull;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010196 RID: 65942 RVA: 0x0025A119 File Offset: 0x00258319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010197 RID: 65943 RVA: 0x0025A124 File Offset: 0x00258324
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Params = input.ReadString();
					}
				}
				else
				{
					this.IsNull = input.ReadBool();
				}
			}
		}

		// Token: 0x040066FF RID: 26367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006700 RID: 26368
		public const int ParamsFieldNumber = 9;

		// Token: 0x04006701 RID: 26369
		private string params_ = "";

		// Token: 0x04006702 RID: 26370
		public const int IsNullFieldNumber = 6;

		// Token: 0x04006703 RID: 26371
		private bool isNull_;
	}
}
