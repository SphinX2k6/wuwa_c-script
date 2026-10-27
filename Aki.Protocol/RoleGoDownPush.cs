using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001083 RID: 4227
	[NetMessage(EMessageId.RoleGoDownPush)]
	public sealed class RoleGoDownPush : IMessage<RoleGoDownPush>, IMessage, IEquatable<RoleGoDownPush>, IDeepCloneable<RoleGoDownPush>, IBufferMessage
	{
		// Token: 0x06016942 RID: 92482 RVA: 0x00347F05 File Offset: 0x00346105
		[NullableContext(1)]
		public static RoleGoDownPush Create()
		{
			return new RoleGoDownPush();
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x06016943 RID: 92483 RVA: 0x00347F0C File Offset: 0x0034610C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x06016944 RID: 92484 RVA: 0x00347F0F File Offset: 0x0034610F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGoDownPush.Descriptor;
			}
		}

		// Token: 0x06016945 RID: 92485 RVA: 0x00347F16 File Offset: 0x00346116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush()
		{
		}

		// Token: 0x06016946 RID: 92486 RVA: 0x00347F1E File Offset: 0x0034611E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush(RoleGoDownPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016947 RID: 92487 RVA: 0x00347F37 File Offset: 0x00346137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGoDownPush Clone()
		{
			return new RoleGoDownPush(this);
		}

		// Token: 0x06016948 RID: 92488 RVA: 0x00347F3F File Offset: 0x0034613F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGoDownPush);
		}

		// Token: 0x06016949 RID: 92489 RVA: 0x00347F4D File Offset: 0x0034614D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGoDownPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601694A RID: 92490 RVA: 0x00347F6C File Offset: 0x0034616C
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

		// Token: 0x0601694B RID: 92491 RVA: 0x00347F92 File Offset: 0x00346192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601694C RID: 92492 RVA: 0x00347F9F File Offset: 0x0034619F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601694D RID: 92493 RVA: 0x00347FA8 File Offset: 0x003461A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601694E RID: 92494 RVA: 0x00347FC0 File Offset: 0x003461C0
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

		// Token: 0x0601694F RID: 92495 RVA: 0x00347FE6 File Offset: 0x003461E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGoDownPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016950 RID: 92496 RVA: 0x00348003 File Offset: 0x00346203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016951 RID: 92497 RVA: 0x0034800C File Offset: 0x0034620C
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

		// Token: 0x040086E2 RID: 34530
		private UnknownFieldSet _unknownFields;
	}
}
