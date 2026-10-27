using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F5 RID: 5365
	[NetMessage(EMessageId.WeaponRemoveNotify)]
	public sealed class WeaponRemoveNotify : IMessage<WeaponRemoveNotify>, IMessage, IEquatable<WeaponRemoveNotify>, IDeepCloneable<WeaponRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601C5D7 RID: 116183 RVA: 0x0041927F File Offset: 0x0041747F
		[NullableContext(1)]
		public static WeaponRemoveNotify Create()
		{
			return new WeaponRemoveNotify();
		}

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x0601C5D8 RID: 116184 RVA: 0x00419286 File Offset: 0x00417486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x0601C5D9 RID: 116185 RVA: 0x00419289 File Offset: 0x00417489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601C5DA RID: 116186 RVA: 0x00419290 File Offset: 0x00417490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponRemoveNotify()
		{
		}

		// Token: 0x0601C5DB RID: 116187 RVA: 0x00419298 File Offset: 0x00417498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponRemoveNotify(WeaponRemoveNotify other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5DC RID: 116188 RVA: 0x004192BD File Offset: 0x004174BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponRemoveNotify Clone()
		{
			return new WeaponRemoveNotify(this);
		}

		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x0601C5DD RID: 116189 RVA: 0x004192C5 File Offset: 0x004174C5
		// (set) Token: 0x0601C5DE RID: 116190 RVA: 0x004192CD File Offset: 0x004174CD
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

		// Token: 0x0601C5DF RID: 116191 RVA: 0x004192D6 File Offset: 0x004174D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponRemoveNotify);
		}

		// Token: 0x0601C5E0 RID: 116192 RVA: 0x004192E4 File Offset: 0x004174E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponRemoveNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5E1 RID: 116193 RVA: 0x00419314 File Offset: 0x00417514
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

		// Token: 0x0601C5E2 RID: 116194 RVA: 0x00419353 File Offset: 0x00417553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5E3 RID: 116195 RVA: 0x00419360 File Offset: 0x00417560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5E4 RID: 116196 RVA: 0x00419369 File Offset: 0x00417569
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

		// Token: 0x0601C5E5 RID: 116197 RVA: 0x0041939C File Offset: 0x0041759C
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

		// Token: 0x0601C5E6 RID: 116198 RVA: 0x004193DA File Offset: 0x004175DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponRemoveNotify other)
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

		// Token: 0x0601C5E7 RID: 116199 RVA: 0x0041940B File Offset: 0x0041760B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5E8 RID: 116200 RVA: 0x00419414 File Offset: 0x00417614
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

		// Token: 0x0400A27F RID: 41599
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A280 RID: 41600
		public const int IncIdFieldNumber = 12;

		// Token: 0x0400A281 RID: 41601
		private int incId_;
	}
}
