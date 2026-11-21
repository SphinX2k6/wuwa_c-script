using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF3 RID: 3059
	[NetMessage(EMessageId.PbGetRoleListRequest)]
	public sealed class PbGetRoleListRequest : IMessage<PbGetRoleListRequest>, IMessage, IEquatable<PbGetRoleListRequest>, IDeepCloneable<PbGetRoleListRequest>, IBufferMessage
	{
		// Token: 0x06010A18 RID: 68120 RVA: 0x0026FF19 File Offset: 0x0026E119
		[NullableContext(1)]
		public static PbGetRoleListRequest Create()
		{
			return new PbGetRoleListRequest();
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x06010A19 RID: 68121 RVA: 0x0026FF20 File Offset: 0x0026E120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x06010A1A RID: 68122 RVA: 0x0026FF23 File Offset: 0x0026E123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbGetRoleListRequest.Descriptor;
			}
		}

		// Token: 0x06010A1B RID: 68123 RVA: 0x0026FF2A File Offset: 0x0026E12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListRequest()
		{
		}

		// Token: 0x06010A1C RID: 68124 RVA: 0x0026FF32 File Offset: 0x0026E132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListRequest(PbGetRoleListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A1D RID: 68125 RVA: 0x0026FF4B File Offset: 0x0026E14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbGetRoleListRequest Clone()
		{
			return new PbGetRoleListRequest(this);
		}

		// Token: 0x06010A1E RID: 68126 RVA: 0x0026FF53 File Offset: 0x0026E153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbGetRoleListRequest);
		}

		// Token: 0x06010A1F RID: 68127 RVA: 0x0026FF61 File Offset: 0x0026E161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbGetRoleListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010A20 RID: 68128 RVA: 0x0026FF80 File Offset: 0x0026E180
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

		// Token: 0x06010A21 RID: 68129 RVA: 0x0026FFA6 File Offset: 0x0026E1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A22 RID: 68130 RVA: 0x0026FFB3 File Offset: 0x0026E1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A23 RID: 68131 RVA: 0x0026FFBC File Offset: 0x0026E1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A24 RID: 68132 RVA: 0x0026FFD4 File Offset: 0x0026E1D4
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

		// Token: 0x06010A25 RID: 68133 RVA: 0x0026FFFA File Offset: 0x0026E1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbGetRoleListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A26 RID: 68134 RVA: 0x00270017 File Offset: 0x0026E217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A27 RID: 68135 RVA: 0x00270020 File Offset: 0x0026E220
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

		// Token: 0x04006A2F RID: 27183
		private UnknownFieldSet _unknownFields;
	}
}
