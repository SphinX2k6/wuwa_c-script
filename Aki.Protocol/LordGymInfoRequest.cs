using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000960 RID: 2400
	[NetMessage(EMessageId.LordGymInfoRequest)]
	public sealed class LordGymInfoRequest : IMessage<LordGymInfoRequest>, IMessage, IEquatable<LordGymInfoRequest>, IDeepCloneable<LordGymInfoRequest>, IBufferMessage
	{
		// Token: 0x0600D373 RID: 54131 RVA: 0x001F2645 File Offset: 0x001F0845
		[NullableContext(1)]
		public static LordGymInfoRequest Create()
		{
			return new LordGymInfoRequest();
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600D374 RID: 54132 RVA: 0x001F264C File Offset: 0x001F084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x001F264F File Offset: 0x001F084F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600D376 RID: 54134 RVA: 0x001F2656 File Offset: 0x001F0856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoRequest()
		{
		}

		// Token: 0x0600D377 RID: 54135 RVA: 0x001F265E File Offset: 0x001F085E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoRequest(LordGymInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D378 RID: 54136 RVA: 0x001F2677 File Offset: 0x001F0877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoRequest Clone()
		{
			return new LordGymInfoRequest(this);
		}

		// Token: 0x0600D379 RID: 54137 RVA: 0x001F267F File Offset: 0x001F087F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymInfoRequest);
		}

		// Token: 0x0600D37A RID: 54138 RVA: 0x001F268D File Offset: 0x001F088D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D37B RID: 54139 RVA: 0x001F26AC File Offset: 0x001F08AC
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

		// Token: 0x0600D37C RID: 54140 RVA: 0x001F26D2 File Offset: 0x001F08D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x001F26DF File Offset: 0x001F08DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D37E RID: 54142 RVA: 0x001F26E8 File Offset: 0x001F08E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D37F RID: 54143 RVA: 0x001F2700 File Offset: 0x001F0900
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

		// Token: 0x0600D380 RID: 54144 RVA: 0x001F2726 File Offset: 0x001F0926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x001F2743 File Offset: 0x001F0943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D382 RID: 54146 RVA: 0x001F274C File Offset: 0x001F094C
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

		// Token: 0x040058D7 RID: 22743
		private UnknownFieldSet _unknownFields;
	}
}
