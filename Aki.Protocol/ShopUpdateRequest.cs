using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FA RID: 4602
	[NetMessage(EMessageId.ShopUpdateRequest)]
	public sealed class ShopUpdateRequest : IMessage<ShopUpdateRequest>, IMessage, IEquatable<ShopUpdateRequest>, IDeepCloneable<ShopUpdateRequest>, IBufferMessage
	{
		// Token: 0x06018895 RID: 100501 RVA: 0x0039197D File Offset: 0x0038FB7D
		[NullableContext(1)]
		public static ShopUpdateRequest Create()
		{
			return new ShopUpdateRequest();
		}

		// Token: 0x170052A9 RID: 21161
		// (get) Token: 0x06018896 RID: 100502 RVA: 0x00391984 File Offset: 0x0038FB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052AA RID: 21162
		// (get) Token: 0x06018897 RID: 100503 RVA: 0x00391987 File Offset: 0x0038FB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06018898 RID: 100504 RVA: 0x0039198E File Offset: 0x0038FB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateRequest()
		{
		}

		// Token: 0x06018899 RID: 100505 RVA: 0x00391996 File Offset: 0x0038FB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateRequest(ShopUpdateRequest other) : this()
		{
			this.shopId_ = other.shopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601889A RID: 100506 RVA: 0x003919BB File Offset: 0x0038FBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateRequest Clone()
		{
			return new ShopUpdateRequest(this);
		}

		// Token: 0x170052AB RID: 21163
		// (get) Token: 0x0601889B RID: 100507 RVA: 0x003919C3 File Offset: 0x0038FBC3
		// (set) Token: 0x0601889C RID: 100508 RVA: 0x003919CB File Offset: 0x0038FBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x0601889D RID: 100509 RVA: 0x003919D4 File Offset: 0x0038FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopUpdateRequest);
		}

		// Token: 0x0601889E RID: 100510 RVA: 0x003919E2 File Offset: 0x0038FBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopUpdateRequest other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601889F RID: 100511 RVA: 0x00391A10 File Offset: 0x0038FC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060188A0 RID: 100512 RVA: 0x00391A4F File Offset: 0x0038FC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188A1 RID: 100513 RVA: 0x00391A5C File Offset: 0x0038FC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188A2 RID: 100514 RVA: 0x00391A65 File Offset: 0x0038FC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188A3 RID: 100515 RVA: 0x00391A98 File Offset: 0x0038FC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060188A4 RID: 100516 RVA: 0x00391AD6 File Offset: 0x0038FCD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060188A5 RID: 100517 RVA: 0x00391B07 File Offset: 0x0038FD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188A6 RID: 100518 RVA: 0x00391B10 File Offset: 0x0038FD10
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400910F RID: 37135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009110 RID: 37136
		public const int ShopIdFieldNumber = 9;

		// Token: 0x04009111 RID: 37137
		private int shopId_;
	}
}
