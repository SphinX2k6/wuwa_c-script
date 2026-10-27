using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FF RID: 511
	[NetMessage(EMessageId.BuffEffectRequest)]
	public sealed class BuffEffectRequest : IMessage<BuffEffectRequest>, IMessage, IEquatable<BuffEffectRequest>, IDeepCloneable<BuffEffectRequest>, IBufferMessage
	{
		// Token: 0x060038A2 RID: 14498 RVA: 0x0008D704 File Offset: 0x0008B904
		[NullableContext(1)]
		public static BuffEffectRequest Create()
		{
			return new BuffEffectRequest();
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x0008D70B File Offset: 0x0008B90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x0008D70E File Offset: 0x0008B90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectRequest.Descriptor;
			}
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0008D715 File Offset: 0x0008B915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest()
		{
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0008D71D File Offset: 0x0008B91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest(BuffEffectRequest other) : this()
		{
			this.handleId_ = other.handleId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0008D74E File Offset: 0x0008B94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest Clone()
		{
			return new BuffEffectRequest(this);
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x0008D756 File Offset: 0x0008B956
		// (set) Token: 0x060038A9 RID: 14505 RVA: 0x0008D75E File Offset: 0x0008B95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x0008D767 File Offset: 0x0008B967
		// (set) Token: 0x060038AB RID: 14507 RVA: 0x0008D76F File Offset: 0x0008B96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x0008D778 File Offset: 0x0008B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectRequest);
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x0008D786 File Offset: 0x0008B986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectRequest other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0008D7C4 File Offset: 0x0008B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0008D81C File Offset: 0x0008BA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0008D829 File Offset: 0x0008BA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0008D834 File Offset: 0x0008BA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HandleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0008D890 File Offset: 0x0008BA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x0008D8E8 File Offset: 0x0008BAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x0008D938 File Offset: 0x0008BB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x0008D944 File Offset: 0x0008BB44
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.HandleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002B42 RID: 11074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B43 RID: 11075
		public const int HandleIdFieldNumber = 7;

		// Token: 0x04002B44 RID: 11076
		private int handleId_;

		// Token: 0x04002B45 RID: 11077
		public const int IndexFieldNumber = 12;

		// Token: 0x04002B46 RID: 11078
		private int index_;
	}
}
