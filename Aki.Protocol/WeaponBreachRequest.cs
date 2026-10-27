using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EA RID: 5354
	[NetMessage(EMessageId.WeaponBreachRequest)]
	public sealed class WeaponBreachRequest : IMessage<WeaponBreachRequest>, IMessage, IEquatable<WeaponBreachRequest>, IDeepCloneable<WeaponBreachRequest>, IBufferMessage
	{
		// Token: 0x0601C4E7 RID: 115943 RVA: 0x004170E1 File Offset: 0x004152E1
		[NullableContext(1)]
		public static WeaponBreachRequest Create()
		{
			return new WeaponBreachRequest();
		}

		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x0601C4E8 RID: 115944 RVA: 0x004170E8 File Offset: 0x004152E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x0601C4E9 RID: 115945 RVA: 0x004170EB File Offset: 0x004152EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponBreachRequest.Descriptor;
			}
		}

		// Token: 0x0601C4EA RID: 115946 RVA: 0x004170F2 File Offset: 0x004152F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachRequest()
		{
		}

		// Token: 0x0601C4EB RID: 115947 RVA: 0x004170FA File Offset: 0x004152FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachRequest(WeaponBreachRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4EC RID: 115948 RVA: 0x0041711F File Offset: 0x0041531F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachRequest Clone()
		{
			return new WeaponBreachRequest(this);
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x0601C4ED RID: 115949 RVA: 0x00417127 File Offset: 0x00415327
		// (set) Token: 0x0601C4EE RID: 115950 RVA: 0x0041712F File Offset: 0x0041532F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0601C4EF RID: 115951 RVA: 0x00417138 File Offset: 0x00415338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponBreachRequest);
		}

		// Token: 0x0601C4F0 RID: 115952 RVA: 0x00417146 File Offset: 0x00415346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponBreachRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4F1 RID: 115953 RVA: 0x00417174 File Offset: 0x00415374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4F2 RID: 115954 RVA: 0x004171B3 File Offset: 0x004153B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4F3 RID: 115955 RVA: 0x004171C0 File Offset: 0x004153C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4F4 RID: 115956 RVA: 0x004171C9 File Offset: 0x004153C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4F5 RID: 115957 RVA: 0x004171FC File Offset: 0x004153FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4F6 RID: 115958 RVA: 0x0041723A File Offset: 0x0041543A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponBreachRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4F7 RID: 115959 RVA: 0x0041726B File Offset: 0x0041546B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4F8 RID: 115960 RVA: 0x00417274 File Offset: 0x00415474
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
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A232 RID: 41522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A233 RID: 41523
		public const int IncIdFieldNumber = 12;

		// Token: 0x0400A234 RID: 41524
		private int incId_;
	}
}
