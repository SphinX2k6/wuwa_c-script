using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000877 RID: 2167
	[NetMessage(EMessageId.JokerGuessStartNewRequest)]
	public sealed class JokerGuessStartNewRequest : IMessage<JokerGuessStartNewRequest>, IMessage, IEquatable<JokerGuessStartNewRequest>, IDeepCloneable<JokerGuessStartNewRequest>, IBufferMessage
	{
		// Token: 0x0600C0FB RID: 49403 RVA: 0x001CA77E File Offset: 0x001C897E
		[NullableContext(1)]
		public static JokerGuessStartNewRequest Create()
		{
			return new JokerGuessStartNewRequest();
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x001CA785 File Offset: 0x001C8985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600C0FD RID: 49405 RVA: 0x001CA788 File Offset: 0x001C8988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessStartNewRequest.Descriptor;
			}
		}

		// Token: 0x0600C0FE RID: 49406 RVA: 0x001CA78F File Offset: 0x001C898F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewRequest()
		{
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x001CA7A2 File Offset: 0x001C89A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewRequest(JokerGuessStartNewRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C100 RID: 49408 RVA: 0x001CA7D3 File Offset: 0x001C89D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewRequest Clone()
		{
			return new JokerGuessStartNewRequest(this);
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600C101 RID: 49409 RVA: 0x001CA7DB File Offset: 0x001C89DB
		// (set) Token: 0x0600C102 RID: 49410 RVA: 0x001CA7E3 File Offset: 0x001C89E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x0600C103 RID: 49411 RVA: 0x001CA7EC File Offset: 0x001C89EC
		// (set) Token: 0x0600C104 RID: 49412 RVA: 0x001CA7F4 File Offset: 0x001C89F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x001CA807 File Offset: 0x001C8A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessStartNewRequest);
		}

		// Token: 0x0600C106 RID: 49414 RVA: 0x001CA818 File Offset: 0x001C8A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessStartNewRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && !(this.TraceId != other.TraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C107 RID: 49415 RVA: 0x001CA868 File Offset: 0x001C8A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.TraceId.Length != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x001CA8C2 File Offset: 0x001C8AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x001CA8CF File Offset: 0x001C8ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C10A RID: 49418 RVA: 0x001CA8D8 File Offset: 0x001C8AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TraceId);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C10B RID: 49419 RVA: 0x001CA938 File Offset: 0x001C8B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.TraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C10C RID: 49420 RVA: 0x001CA994 File Offset: 0x001C8B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessStartNewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.TraceId.Length != 0)
			{
				this.TraceId = other.TraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C10D RID: 49421 RVA: 0x001CA9E9 File Offset: 0x001C8BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C10E RID: 49422 RVA: 0x001CA9F4 File Offset: 0x001C8BF4
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
				if (num != 10U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.TraceId = input.ReadString();
				}
			}
		}

		// Token: 0x040053C4 RID: 21444
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053C5 RID: 21445
		public const int LevelIdFieldNumber = 3;

		// Token: 0x040053C6 RID: 21446
		private int levelId_;

		// Token: 0x040053C7 RID: 21447
		public const int TraceIdFieldNumber = 1;

		// Token: 0x040053C8 RID: 21448
		private string traceId_ = "";
	}
}
