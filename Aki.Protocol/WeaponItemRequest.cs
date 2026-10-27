using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F1 RID: 5361
	[NetMessage(EMessageId.WeaponItemRequest)]
	public sealed class WeaponItemRequest : IMessage<WeaponItemRequest>, IMessage, IEquatable<WeaponItemRequest>, IDeepCloneable<WeaponItemRequest>, IBufferMessage
	{
		// Token: 0x0601C587 RID: 116103 RVA: 0x00418805 File Offset: 0x00416A05
		[NullableContext(1)]
		public static WeaponItemRequest Create()
		{
			return new WeaponItemRequest();
		}

		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x0601C588 RID: 116104 RVA: 0x0041880C File Offset: 0x00416A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x0601C589 RID: 116105 RVA: 0x0041880F File Offset: 0x00416A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemRequest.Descriptor;
			}
		}

		// Token: 0x0601C58A RID: 116106 RVA: 0x00418816 File Offset: 0x00416A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRequest()
		{
		}

		// Token: 0x0601C58B RID: 116107 RVA: 0x0041881E File Offset: 0x00416A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRequest(WeaponItemRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C58C RID: 116108 RVA: 0x00418837 File Offset: 0x00416A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRequest Clone()
		{
			return new WeaponItemRequest(this);
		}

		// Token: 0x0601C58D RID: 116109 RVA: 0x0041883F File Offset: 0x00416A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemRequest);
		}

		// Token: 0x0601C58E RID: 116110 RVA: 0x0041884D File Offset: 0x00416A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C58F RID: 116111 RVA: 0x0041886C File Offset: 0x00416A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C590 RID: 116112 RVA: 0x00418892 File Offset: 0x00416A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C591 RID: 116113 RVA: 0x0041889F File Offset: 0x00416A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C592 RID: 116114 RVA: 0x004188A8 File Offset: 0x00416AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C593 RID: 116115 RVA: 0x004188C0 File Offset: 0x00416AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C594 RID: 116116 RVA: 0x004188E6 File Offset: 0x00416AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C595 RID: 116117 RVA: 0x00418903 File Offset: 0x00416B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C596 RID: 116118 RVA: 0x0041890C File Offset: 0x00416B0C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A268 RID: 41576
		private UnknownFieldSet _unknownFields;
	}
}
