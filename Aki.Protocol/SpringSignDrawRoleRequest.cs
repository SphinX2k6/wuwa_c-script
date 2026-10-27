using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127F RID: 4735
	[NetMessage(EMessageId.SpringSignDrawRoleRequest)]
	public sealed class SpringSignDrawRoleRequest : IMessage<SpringSignDrawRoleRequest>, IMessage, IEquatable<SpringSignDrawRoleRequest>, IDeepCloneable<SpringSignDrawRoleRequest>, IBufferMessage
	{
		// Token: 0x06019386 RID: 103302 RVA: 0x003AB4E5 File Offset: 0x003A96E5
		[NullableContext(1)]
		public static SpringSignDrawRoleRequest Create()
		{
			return new SpringSignDrawRoleRequest();
		}

		// Token: 0x17005516 RID: 21782
		// (get) Token: 0x06019387 RID: 103303 RVA: 0x003AB4EC File Offset: 0x003A96EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005517 RID: 21783
		// (get) Token: 0x06019388 RID: 103304 RVA: 0x003AB4EF File Offset: 0x003A96EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRoleRequest.Descriptor;
			}
		}

		// Token: 0x06019389 RID: 103305 RVA: 0x003AB4F6 File Offset: 0x003A96F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleRequest()
		{
		}

		// Token: 0x0601938A RID: 103306 RVA: 0x003AB4FE File Offset: 0x003A96FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleRequest(SpringSignDrawRoleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601938B RID: 103307 RVA: 0x003AB517 File Offset: 0x003A9717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleRequest Clone()
		{
			return new SpringSignDrawRoleRequest(this);
		}

		// Token: 0x0601938C RID: 103308 RVA: 0x003AB51F File Offset: 0x003A971F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRoleRequest);
		}

		// Token: 0x0601938D RID: 103309 RVA: 0x003AB52D File Offset: 0x003A972D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRoleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601938E RID: 103310 RVA: 0x003AB54C File Offset: 0x003A974C
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

		// Token: 0x0601938F RID: 103311 RVA: 0x003AB572 File Offset: 0x003A9772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019390 RID: 103312 RVA: 0x003AB57F File Offset: 0x003A977F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019391 RID: 103313 RVA: 0x003AB588 File Offset: 0x003A9788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019392 RID: 103314 RVA: 0x003AB5A0 File Offset: 0x003A97A0
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

		// Token: 0x06019393 RID: 103315 RVA: 0x003AB5C6 File Offset: 0x003A97C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019394 RID: 103316 RVA: 0x003AB5E3 File Offset: 0x003A97E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019395 RID: 103317 RVA: 0x003AB5EC File Offset: 0x003A97EC
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

		// Token: 0x04009468 RID: 37992
		private UnknownFieldSet _unknownFields;
	}
}
