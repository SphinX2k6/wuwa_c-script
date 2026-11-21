using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000260 RID: 608
	[NetMessage(EMessageId.ChangeSceneModeNotify)]
	public sealed class ChangeSceneModeNotify : IMessage<ChangeSceneModeNotify>, IMessage, IEquatable<ChangeSceneModeNotify>, IDeepCloneable<ChangeSceneModeNotify>, IBufferMessage
	{
		// Token: 0x0600409A RID: 16538 RVA: 0x0009EE06 File Offset: 0x0009D006
		[NullableContext(1)]
		public static ChangeSceneModeNotify Create()
		{
			return new ChangeSceneModeNotify();
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x0009EE0D File Offset: 0x0009D00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x0009EE10 File Offset: 0x0009D010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSceneModeNotify.Descriptor;
			}
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0009EE17 File Offset: 0x0009D017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeNotify()
		{
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0009EE2A File Offset: 0x0009D02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeNotify(ChangeSceneModeNotify other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this.mode_ = other.mode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0009EE5B File Offset: 0x0009D05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSceneModeNotify Clone()
		{
			return new ChangeSceneModeNotify(this);
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x0009EE63 File Offset: 0x0009D063
		// (set) Token: 0x060040A1 RID: 16545 RVA: 0x0009EE6B File Offset: 0x0009D06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x0009EE7E File Offset: 0x0009D07E
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x0009EE86 File Offset: 0x0009D086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneMode Mode
		{
			get
			{
				return this.mode_;
			}
			set
			{
				this.mode_ = value;
			}
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x0009EE8F File Offset: 0x0009D08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSceneModeNotify);
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x0009EEA0 File Offset: 0x0009D0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSceneModeNotify other)
		{
			return other != null && (other == this || (!(this.SceneId != other.SceneId) && this.Mode == other.Mode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0009EEF0 File Offset: 0x0009D0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.Mode != SceneMode.Single)
			{
				num ^= this.Mode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0009EF50 File Offset: 0x0009D150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x0009EF5D File Offset: 0x0009D15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x0009EF68 File Offset: 0x0009D168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Mode != SceneMode.Single)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Mode);
			}
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0009EFC8 File Offset: 0x0009D1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			if (this.Mode != SceneMode.Single)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Mode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0009F024 File Offset: 0x0009D224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSceneModeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.Mode != SceneMode.Single)
			{
				this.Mode = other.Mode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0009F079 File Offset: 0x0009D279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0009F084 File Offset: 0x0009D284
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
				if (num != 48U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SceneId = input.ReadString();
					}
				}
				else
				{
					this.Mode = (SceneMode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002DC1 RID: 11713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC2 RID: 11714
		public const int SceneIdFieldNumber = 10;

		// Token: 0x04002DC3 RID: 11715
		private string sceneId_ = "";

		// Token: 0x04002DC4 RID: 11716
		public const int ModeFieldNumber = 6;

		// Token: 0x04002DC5 RID: 11717
		private SceneMode mode_;
	}
}
