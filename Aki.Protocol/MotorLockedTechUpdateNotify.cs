using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A78 RID: 2680
	[NetMessage(EMessageId.MotorLockedTechUpdateNotify)]
	public sealed class MotorLockedTechUpdateNotify : IMessage<MotorLockedTechUpdateNotify>, IMessage, IEquatable<MotorLockedTechUpdateNotify>, IDeepCloneable<MotorLockedTechUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E999 RID: 59801 RVA: 0x00221AF8 File Offset: 0x0021FCF8
		[NullableContext(1)]
		public static MotorLockedTechUpdateNotify Create()
		{
			return new MotorLockedTechUpdateNotify();
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x00221AFF File Offset: 0x0021FCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0600E99B RID: 59803 RVA: 0x00221B02 File Offset: 0x0021FD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLockedTechUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E99C RID: 59804 RVA: 0x00221B09 File Offset: 0x0021FD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLockedTechUpdateNotify()
		{
		}

		// Token: 0x0600E99D RID: 59805 RVA: 0x00221B1C File Offset: 0x0021FD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLockedTechUpdateNotify(MotorLockedTechUpdateNotify other) : this()
		{
			this.treeId_ = other.treeId_;
			this.tech_ = other.tech_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x00221B52 File Offset: 0x0021FD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLockedTechUpdateNotify Clone()
		{
			return new MotorLockedTechUpdateNotify(this);
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0600E99F RID: 59807 RVA: 0x00221B5A File Offset: 0x0021FD5A
		// (set) Token: 0x0600E9A0 RID: 59808 RVA: 0x00221B62 File Offset: 0x0021FD62
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

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600E9A1 RID: 59809 RVA: 0x00221B6B File Offset: 0x0021FD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTechPb> Tech
		{
			get
			{
				return this.tech_;
			}
		}

		// Token: 0x0600E9A2 RID: 59810 RVA: 0x00221B73 File Offset: 0x0021FD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLockedTechUpdateNotify);
		}

		// Token: 0x0600E9A3 RID: 59811 RVA: 0x00221B84 File Offset: 0x0021FD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLockedTechUpdateNotify other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.tech_.Equals(other.tech_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9A4 RID: 59812 RVA: 0x00221BD4 File Offset: 0x0021FDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			num ^= this.tech_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x00221C21 File Offset: 0x0021FE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x00221C2E File Offset: 0x0021FE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x00221C38 File Offset: 0x0021FE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TreeId);
			}
			this.tech_.WriteTo(ref output, MotorLockedTechUpdateNotify._repeated_tech_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x00221C88 File Offset: 0x0021FE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			num += this.tech_.CalculateSize(MotorLockedTechUpdateNotify._repeated_tech_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9A9 RID: 59817 RVA: 0x00221CDC File Offset: 0x0021FEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorLockedTechUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this.tech_.Add(other.tech_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9AA RID: 59818 RVA: 0x00221D29 File Offset: 0x0021FF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9AB RID: 59819 RVA: 0x00221D34 File Offset: 0x0021FF34
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
				if (num != 24U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tech_.AddEntriesFrom(ref input, MotorLockedTechUpdateNotify._repeated_tech_codec);
					}
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EF4 RID: 24308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EF5 RID: 24309
		public const int TreeIdFieldNumber = 3;

		// Token: 0x04005EF6 RID: 24310
		private int treeId_;

		// Token: 0x04005EF7 RID: 24311
		public const int TechFieldNumber = 5;

		// Token: 0x04005EF8 RID: 24312
		private static readonly FieldCodec<MotorTechPb> _repeated_tech_codec = FieldCodec.ForMessage<MotorTechPb>(42U, MotorTechPb.Parser);

		// Token: 0x04005EF9 RID: 24313
		private readonly RepeatedField<MotorTechPb> tech_ = new RepeatedField<MotorTechPb>();
	}
}
