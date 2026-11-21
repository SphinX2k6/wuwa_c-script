using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000866 RID: 2150
	[NetMessage(EMessageId.JokerGuessStartNewRequest)]
	public sealed class JokerGuessStartNewRequest : IMessage<JokerGuessStartNewRequest>, IMessage, IEquatable<JokerGuessStartNewRequest>, IDeepCloneable<JokerGuessStartNewRequest>, IBufferMessage
	{
		// Token: 0x0600BFDF RID: 49119 RVA: 0x001C8496 File Offset: 0x001C6696
		[NullableContext(1)]
		public static JokerGuessStartNewRequest Create()
		{
			return new JokerGuessStartNewRequest();
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x0600BFE0 RID: 49120 RVA: 0x001C849D File Offset: 0x001C669D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x0600BFE1 RID: 49121 RVA: 0x001C84A0 File Offset: 0x001C66A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessStartNewRequest.Descriptor;
			}
		}

		// Token: 0x0600BFE2 RID: 49122 RVA: 0x001C84A7 File Offset: 0x001C66A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewRequest()
		{
		}

		// Token: 0x0600BFE3 RID: 49123 RVA: 0x001C84BA File Offset: 0x001C66BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewRequest(JokerGuessStartNewRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x001C84EB File Offset: 0x001C66EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewRequest Clone()
		{
			return new JokerGuessStartNewRequest(this);
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x001C84F3 File Offset: 0x001C66F3
		// (set) Token: 0x0600BFE6 RID: 49126 RVA: 0x001C84FB File Offset: 0x001C66FB
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

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x0600BFE7 RID: 49127 RVA: 0x001C8504 File Offset: 0x001C6704
		// (set) Token: 0x0600BFE8 RID: 49128 RVA: 0x001C850C File Offset: 0x001C670C
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

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x001C851F File Offset: 0x001C671F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessStartNewRequest);
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x001C8530 File Offset: 0x001C6730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessStartNewRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && !(this.TraceId != other.TraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x001C8580 File Offset: 0x001C6780
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

		// Token: 0x0600BFEC RID: 49132 RVA: 0x001C85DA File Offset: 0x001C67DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x001C85E7 File Offset: 0x001C67E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x001C85F0 File Offset: 0x001C67F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TraceId);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x001C8650 File Offset: 0x001C6850
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

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x001C86AC File Offset: 0x001C68AC
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

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x001C8701 File Offset: 0x001C6901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFF2 RID: 49138 RVA: 0x001C870C File Offset: 0x001C690C
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
				if (num != 18U)
				{
					if (num != 80U)
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

		// Token: 0x040053CB RID: 21451
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053CC RID: 21452
		public const int LevelIdFieldNumber = 10;

		// Token: 0x040053CD RID: 21453
		private int levelId_;

		// Token: 0x040053CE RID: 21454
		public const int TraceIdFieldNumber = 2;

		// Token: 0x040053CF RID: 21455
		private string traceId_ = "";
	}
}
