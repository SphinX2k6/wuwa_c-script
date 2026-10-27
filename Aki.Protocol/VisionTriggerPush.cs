using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E6 RID: 5350
	[NetMessage(EMessageId.VisionTriggerPush)]
	public sealed class VisionTriggerPush : IMessage<VisionTriggerPush>, IMessage, IEquatable<VisionTriggerPush>, IDeepCloneable<VisionTriggerPush>, IBufferMessage
	{
		// Token: 0x0601C49F RID: 115871 RVA: 0x00416921 File Offset: 0x00414B21
		[NullableContext(1)]
		public static VisionTriggerPush Create()
		{
			return new VisionTriggerPush();
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x0601C4A0 RID: 115872 RVA: 0x00416928 File Offset: 0x00414B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x0601C4A1 RID: 115873 RVA: 0x0041692B File Offset: 0x00414B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionTriggerPush.Descriptor;
			}
		}

		// Token: 0x0601C4A2 RID: 115874 RVA: 0x00416932 File Offset: 0x00414B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush()
		{
		}

		// Token: 0x0601C4A3 RID: 115875 RVA: 0x0041693A File Offset: 0x00414B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush(VisionTriggerPush other) : this()
		{
			this.numberId_ = other.numberId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4A4 RID: 115876 RVA: 0x0041695F File Offset: 0x00414B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerPush Clone()
		{
			return new VisionTriggerPush(this);
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x0601C4A5 RID: 115877 RVA: 0x00416967 File Offset: 0x00414B67
		// (set) Token: 0x0601C4A6 RID: 115878 RVA: 0x0041696F File Offset: 0x00414B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumberId
		{
			get
			{
				return this.numberId_;
			}
			set
			{
				this.numberId_ = value;
			}
		}

		// Token: 0x0601C4A7 RID: 115879 RVA: 0x00416978 File Offset: 0x00414B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionTriggerPush);
		}

		// Token: 0x0601C4A8 RID: 115880 RVA: 0x00416986 File Offset: 0x00414B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionTriggerPush other)
		{
			return other != null && (other == this || (this.NumberId == other.NumberId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4A9 RID: 115881 RVA: 0x004169B4 File Offset: 0x00414BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NumberId != 0)
			{
				num ^= this.NumberId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4AA RID: 115882 RVA: 0x004169F3 File Offset: 0x00414BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4AB RID: 115883 RVA: 0x00416A00 File Offset: 0x00414C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4AC RID: 115884 RVA: 0x00416A09 File Offset: 0x00414C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumberId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4AD RID: 115885 RVA: 0x00416A3C File Offset: 0x00414C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NumberId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4AE RID: 115886 RVA: 0x00416A7A File Offset: 0x00414C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionTriggerPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NumberId != 0)
			{
				this.NumberId = other.NumberId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4AF RID: 115887 RVA: 0x00416AAB File Offset: 0x00414CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4B0 RID: 115888 RVA: 0x00416AB4 File Offset: 0x00414CB4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NumberId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A224 RID: 41508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A225 RID: 41509
		public const int NumberIdFieldNumber = 15;

		// Token: 0x0400A226 RID: 41510
		private int numberId_;
	}
}
