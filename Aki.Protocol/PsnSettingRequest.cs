using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDD RID: 3549
	[NetMessage(EMessageId.PsnSettingRequest)]
	public sealed class PsnSettingRequest : IMessage<PsnSettingRequest>, IMessage, IEquatable<PsnSettingRequest>, IDeepCloneable<PsnSettingRequest>, IBufferMessage
	{
		// Token: 0x060131F2 RID: 78322 RVA: 0x002C9A2A File Offset: 0x002C7C2A
		[NullableContext(1)]
		public static PsnSettingRequest Create()
		{
			return new PsnSettingRequest();
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x060131F3 RID: 78323 RVA: 0x002C9A31 File Offset: 0x002C7C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x060131F4 RID: 78324 RVA: 0x002C9A34 File Offset: 0x002C7C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingRequest.Descriptor;
			}
		}

		// Token: 0x060131F5 RID: 78325 RVA: 0x002C9A3B File Offset: 0x002C7C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingRequest()
		{
		}

		// Token: 0x060131F6 RID: 78326 RVA: 0x002C9A43 File Offset: 0x002C7C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingRequest(PsnSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131F7 RID: 78327 RVA: 0x002C9A5C File Offset: 0x002C7C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingRequest Clone()
		{
			return new PsnSettingRequest(this);
		}

		// Token: 0x060131F8 RID: 78328 RVA: 0x002C9A64 File Offset: 0x002C7C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingRequest);
		}

		// Token: 0x060131F9 RID: 78329 RVA: 0x002C9A72 File Offset: 0x002C7C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060131FA RID: 78330 RVA: 0x002C9A90 File Offset: 0x002C7C90
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

		// Token: 0x060131FB RID: 78331 RVA: 0x002C9AB6 File Offset: 0x002C7CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131FC RID: 78332 RVA: 0x002C9AC3 File Offset: 0x002C7CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131FD RID: 78333 RVA: 0x002C9ACC File Offset: 0x002C7CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131FE RID: 78334 RVA: 0x002C9AE4 File Offset: 0x002C7CE4
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

		// Token: 0x060131FF RID: 78335 RVA: 0x002C9B0A File Offset: 0x002C7D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013200 RID: 78336 RVA: 0x002C9B27 File Offset: 0x002C7D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013201 RID: 78337 RVA: 0x002C9B30 File Offset: 0x002C7D30
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

		// Token: 0x04007644 RID: 30276
		private UnknownFieldSet _unknownFields;
	}
}
