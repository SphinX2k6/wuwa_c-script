using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000281 RID: 641
	[NetMessage(EMessageId.CheckClientPush)]
	public sealed class CheckClientPush : IMessage<CheckClientPush>, IMessage, IEquatable<CheckClientPush>, IDeepCloneable<CheckClientPush>, IBufferMessage
	{
		// Token: 0x0600432E RID: 17198 RVA: 0x000A4CD2 File Offset: 0x000A2ED2
		[NullableContext(1)]
		public static CheckClientPush Create()
		{
			return new CheckClientPush();
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x000A4CD9 File Offset: 0x000A2ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x000A4CDC File Offset: 0x000A2EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckClientPush.Descriptor;
			}
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x000A4CE3 File Offset: 0x000A2EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckClientPush()
		{
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x000A4D0C File Offset: 0x000A2F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckClientPush(CheckClientPush other) : this()
		{
			this.appVersion_ = other.appVersion_;
			this.launcherVersion_ = other.launcherVersion_;
			this.resourceVersion_ = other.resourceVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x000A4D49 File Offset: 0x000A2F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckClientPush Clone()
		{
			return new CheckClientPush(this);
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x000A4D51 File Offset: 0x000A2F51
		// (set) Token: 0x06004335 RID: 17205 RVA: 0x000A4D59 File Offset: 0x000A2F59
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

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x000A4D6C File Offset: 0x000A2F6C
		// (set) Token: 0x06004337 RID: 17207 RVA: 0x000A4D74 File Offset: 0x000A2F74
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

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x000A4D87 File Offset: 0x000A2F87
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x000A4D8F File Offset: 0x000A2F8F
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

		// Token: 0x0600433A RID: 17210 RVA: 0x000A4DA2 File Offset: 0x000A2FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckClientPush);
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x000A4DB0 File Offset: 0x000A2FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckClientPush other)
		{
			return other != null && (other == this || (!(this.AppVersion != other.AppVersion) && !(this.LauncherVersion != other.LauncherVersion) && !(this.ResourceVersion != other.ResourceVersion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x000A4E18 File Offset: 0x000A3018
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

		// Token: 0x0600433D RID: 17213 RVA: 0x000A4E8F File Offset: 0x000A308F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x000A4E9C File Offset: 0x000A309C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x000A4EA8 File Offset: 0x000A30A8
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

		// Token: 0x06004340 RID: 17216 RVA: 0x000A4F2C File Offset: 0x000A312C
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

		// Token: 0x06004341 RID: 17217 RVA: 0x000A4FAC File Offset: 0x000A31AC
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

		// Token: 0x06004342 RID: 17218 RVA: 0x000A501F File Offset: 0x000A321F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x000A5028 File Offset: 0x000A3228
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

		// Token: 0x04002E46 RID: 11846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E47 RID: 11847
		public const int AppVersionFieldNumber = 1;

		// Token: 0x04002E48 RID: 11848
		private string appVersion_ = "";

		// Token: 0x04002E49 RID: 11849
		public const int LauncherVersionFieldNumber = 2;

		// Token: 0x04002E4A RID: 11850
		private string launcherVersion_ = "";

		// Token: 0x04002E4B RID: 11851
		public const int ResourceVersionFieldNumber = 3;

		// Token: 0x04002E4C RID: 11852
		private string resourceVersion_ = "";
	}
}
