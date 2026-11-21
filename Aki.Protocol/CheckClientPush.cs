using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000286 RID: 646
	[NetMessage(EMessageId.CheckClientPush)]
	public sealed class CheckClientPush : IMessage<CheckClientPush>, IMessage, IEquatable<CheckClientPush>, IDeepCloneable<CheckClientPush>, IBufferMessage
	{
		// Token: 0x060043D5 RID: 17365 RVA: 0x000A699A File Offset: 0x000A4B9A
		[NullableContext(1)]
		public static CheckClientPush Create()
		{
			return new CheckClientPush();
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x000A69A1 File Offset: 0x000A4BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x000A69A4 File Offset: 0x000A4BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckClientPush.Descriptor;
			}
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x000A69AB File Offset: 0x000A4BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckClientPush()
		{
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000A69D4 File Offset: 0x000A4BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckClientPush(CheckClientPush other) : this()
		{
			this.appVersion_ = other.appVersion_;
			this.launcherVersion_ = other.launcherVersion_;
			this.resourceVersion_ = other.resourceVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x000A6A11 File Offset: 0x000A4C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckClientPush Clone()
		{
			return new CheckClientPush(this);
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x000A6A19 File Offset: 0x000A4C19
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x000A6A21 File Offset: 0x000A4C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AppVersion
		{
			get
			{
				return this.appVersion_;
			}
			set
			{
				this.appVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x000A6A34 File Offset: 0x000A4C34
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x000A6A3C File Offset: 0x000A4C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LauncherVersion
		{
			get
			{
				return this.launcherVersion_;
			}
			set
			{
				this.launcherVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x000A6A4F File Offset: 0x000A4C4F
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x000A6A57 File Offset: 0x000A4C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResourceVersion
		{
			get
			{
				return this.resourceVersion_;
			}
			set
			{
				this.resourceVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x000A6A6A File Offset: 0x000A4C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckClientPush);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x000A6A78 File Offset: 0x000A4C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckClientPush other)
		{
			return other != null && (other == this || (!(this.AppVersion != other.AppVersion) && !(this.LauncherVersion != other.LauncherVersion) && !(this.ResourceVersion != other.ResourceVersion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x000A6AE0 File Offset: 0x000A4CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AppVersion.Length != 0)
			{
				num ^= this.AppVersion.GetHashCode();
			}
			if (this.LauncherVersion.Length != 0)
			{
				num ^= this.LauncherVersion.GetHashCode();
			}
			if (this.ResourceVersion.Length != 0)
			{
				num ^= this.ResourceVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x000A6B57 File Offset: 0x000A4D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x000A6B64 File Offset: 0x000A4D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000A6B70 File Offset: 0x000A4D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AppVersion.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AppVersion);
			}
			if (this.LauncherVersion.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.LauncherVersion);
			}
			if (this.ResourceVersion.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ResourceVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000A6BF4 File Offset: 0x000A4DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AppVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AppVersion);
			}
			if (this.LauncherVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LauncherVersion);
			}
			if (this.ResourceVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ResourceVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x000A6C74 File Offset: 0x000A4E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckClientPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AppVersion.Length != 0)
			{
				this.AppVersion = other.AppVersion;
			}
			if (other.LauncherVersion.Length != 0)
			{
				this.LauncherVersion = other.LauncherVersion;
			}
			if (other.ResourceVersion.Length != 0)
			{
				this.ResourceVersion = other.ResourceVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x000A6CE7 File Offset: 0x000A4EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x000A6CF0 File Offset: 0x000A4EF0
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ResourceVersion = input.ReadString();
						}
					}
					else
					{
						this.LauncherVersion = input.ReadString();
					}
				}
				else
				{
					this.AppVersion = input.ReadString();
				}
			}
		}

		// Token: 0x04002ECA RID: 11978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ECB RID: 11979
		public const int AppVersionFieldNumber = 1;

		// Token: 0x04002ECC RID: 11980
		private string appVersion_ = "";

		// Token: 0x04002ECD RID: 11981
		public const int LauncherVersionFieldNumber = 2;

		// Token: 0x04002ECE RID: 11982
		private string launcherVersion_ = "";

		// Token: 0x04002ECF RID: 11983
		public const int ResourceVersionFieldNumber = 3;

		// Token: 0x04002ED0 RID: 11984
		private string resourceVersion_ = "";
	}
}
