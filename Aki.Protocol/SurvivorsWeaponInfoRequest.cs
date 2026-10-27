using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F2 RID: 4850
	[NetMessage(EMessageId.SurvivorsWeaponInfoRequest)]
	public sealed class SurvivorsWeaponInfoRequest : IMessage<SurvivorsWeaponInfoRequest>, IMessage, IEquatable<SurvivorsWeaponInfoRequest>, IDeepCloneable<SurvivorsWeaponInfoRequest>, IBufferMessage
	{
		// Token: 0x06019CA1 RID: 105633 RVA: 0x003BF8CA File Offset: 0x003BDACA
		[NullableContext(1)]
		public static SurvivorsWeaponInfoRequest Create()
		{
			return new SurvivorsWeaponInfoRequest();
		}

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x06019CA2 RID: 105634 RVA: 0x003BF8D1 File Offset: 0x003BDAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x06019CA3 RID: 105635 RVA: 0x003BF8D4 File Offset: 0x003BDAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponInfoRequest.Descriptor;
			}
		}

		// Token: 0x06019CA4 RID: 105636 RVA: 0x003BF8DB File Offset: 0x003BDADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoRequest()
		{
		}

		// Token: 0x06019CA5 RID: 105637 RVA: 0x003BF8E3 File Offset: 0x003BDAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoRequest(SurvivorsWeaponInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CA6 RID: 105638 RVA: 0x003BF8FC File Offset: 0x003BDAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoRequest Clone()
		{
			return new SurvivorsWeaponInfoRequest(this);
		}

		// Token: 0x06019CA7 RID: 105639 RVA: 0x003BF904 File Offset: 0x003BDB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponInfoRequest);
		}

		// Token: 0x06019CA8 RID: 105640 RVA: 0x003BF912 File Offset: 0x003BDB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019CA9 RID: 105641 RVA: 0x003BF930 File Offset: 0x003BDB30
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

		// Token: 0x06019CAA RID: 105642 RVA: 0x003BF956 File Offset: 0x003BDB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CAB RID: 105643 RVA: 0x003BF963 File Offset: 0x003BDB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CAC RID: 105644 RVA: 0x003BF96C File Offset: 0x003BDB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019CAD RID: 105645 RVA: 0x003BF984 File Offset: 0x003BDB84
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

		// Token: 0x06019CAE RID: 105646 RVA: 0x003BF9AA File Offset: 0x003BDBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019CAF RID: 105647 RVA: 0x003BF9C7 File Offset: 0x003BDBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CB0 RID: 105648 RVA: 0x003BF9D0 File Offset: 0x003BDBD0
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

		// Token: 0x040096F2 RID: 38642
		private UnknownFieldSet _unknownFields;
	}
}
