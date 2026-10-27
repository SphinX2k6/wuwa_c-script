using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001339 RID: 4921
	[NetMessage(EMessageId.TeleportFinishRequest)]
	public sealed class TeleportFinishRequest : IMessage<TeleportFinishRequest>, IMessage, IEquatable<TeleportFinishRequest>, IDeepCloneable<TeleportFinishRequest>, IBufferMessage
	{
		// Token: 0x0601A24D RID: 107085 RVA: 0x003CC0F5 File Offset: 0x003CA2F5
		[NullableContext(1)]
		public static TeleportFinishRequest Create()
		{
			return new TeleportFinishRequest();
		}

		// Token: 0x1700582C RID: 22572
		// (get) Token: 0x0601A24E RID: 107086 RVA: 0x003CC0FC File Offset: 0x003CA2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x0601A24F RID: 107087 RVA: 0x003CC0FF File Offset: 0x003CA2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601A250 RID: 107088 RVA: 0x003CC106 File Offset: 0x003CA306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishRequest()
		{
		}

		// Token: 0x0601A251 RID: 107089 RVA: 0x003CC10E File Offset: 0x003CA30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishRequest(TeleportFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A252 RID: 107090 RVA: 0x003CC127 File Offset: 0x003CA327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishRequest Clone()
		{
			return new TeleportFinishRequest(this);
		}

		// Token: 0x0601A253 RID: 107091 RVA: 0x003CC12F File Offset: 0x003CA32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFinishRequest);
		}

		// Token: 0x0601A254 RID: 107092 RVA: 0x003CC13D File Offset: 0x003CA33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A255 RID: 107093 RVA: 0x003CC15C File Offset: 0x003CA35C
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

		// Token: 0x0601A256 RID: 107094 RVA: 0x003CC182 File Offset: 0x003CA382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A257 RID: 107095 RVA: 0x003CC18F File Offset: 0x003CA38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A258 RID: 107096 RVA: 0x003CC198 File Offset: 0x003CA398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A259 RID: 107097 RVA: 0x003CC1B0 File Offset: 0x003CA3B0
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

		// Token: 0x0601A25A RID: 107098 RVA: 0x003CC1D6 File Offset: 0x003CA3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A25B RID: 107099 RVA: 0x003CC1F3 File Offset: 0x003CA3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A25C RID: 107100 RVA: 0x003CC1FC File Offset: 0x003CA3FC
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

		// Token: 0x04009890 RID: 39056
		private UnknownFieldSet _unknownFields;
	}
}
