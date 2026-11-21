using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5E RID: 3934
	[NetMessage(EMessageId.RoadBookLevelUpRequest)]
	public sealed class RoadBookLevelUpRequest : IMessage<RoadBookLevelUpRequest>, IMessage, IEquatable<RoadBookLevelUpRequest>, IDeepCloneable<RoadBookLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06015108 RID: 86280 RVA: 0x0030E90F File Offset: 0x0030CB0F
		[NullableContext(1)]
		public static RoadBookLevelUpRequest Create()
		{
			return new RoadBookLevelUpRequest();
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x06015109 RID: 86281 RVA: 0x0030E916 File Offset: 0x0030CB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x0601510A RID: 86282 RVA: 0x0030E919 File Offset: 0x0030CB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601510B RID: 86283 RVA: 0x0030E920 File Offset: 0x0030CB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpRequest()
		{
		}

		// Token: 0x0601510C RID: 86284 RVA: 0x0030E928 File Offset: 0x0030CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpRequest(RoadBookLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601510D RID: 86285 RVA: 0x0030E941 File Offset: 0x0030CB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookLevelUpRequest Clone()
		{
			return new RoadBookLevelUpRequest(this);
		}

		// Token: 0x0601510E RID: 86286 RVA: 0x0030E949 File Offset: 0x0030CB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookLevelUpRequest);
		}

		// Token: 0x0601510F RID: 86287 RVA: 0x0030E957 File Offset: 0x0030CB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015110 RID: 86288 RVA: 0x0030E978 File Offset: 0x0030CB78
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

		// Token: 0x06015111 RID: 86289 RVA: 0x0030E99E File Offset: 0x0030CB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015112 RID: 86290 RVA: 0x0030E9AB File Offset: 0x0030CBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015113 RID: 86291 RVA: 0x0030E9B4 File Offset: 0x0030CBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015114 RID: 86292 RVA: 0x0030E9CC File Offset: 0x0030CBCC
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

		// Token: 0x06015115 RID: 86293 RVA: 0x0030E9F2 File Offset: 0x0030CBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015116 RID: 86294 RVA: 0x0030EA0F File Offset: 0x0030CC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015117 RID: 86295 RVA: 0x0030EA18 File Offset: 0x0030CC18
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

		// Token: 0x04007F41 RID: 32577
		private UnknownFieldSet _unknownFields;
	}
}
