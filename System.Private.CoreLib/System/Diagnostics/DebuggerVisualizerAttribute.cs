using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x0200088A RID: 2186
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	public sealed class DebuggerVisualizerAttribute : Attribute
	{
		// Token: 0x06008951 RID: 35153 RVA: 0x0014DBE7 File Offset: 0x0014BDE7
		[NullableContext(1)]
		public DebuggerVisualizerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] string visualizerTypeName)
		{
			this.VisualizerTypeName = visualizerTypeName;
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x0014DBF6 File Offset: 0x0014BDF6
		[NullableContext(1)]
		public DebuggerVisualizerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] string visualizerTypeName, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] string visualizerObjectSourceTypeName)
		{
			this.VisualizerTypeName = visualizerTypeName;
			this.VisualizerObjectSourceTypeName = visualizerObjectSourceTypeName;
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x0014DC0C File Offset: 0x0014BE0C
		[NullableContext(1)]
		public DebuggerVisualizerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] string visualizerTypeName, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type visualizerObjectSource)
		{
			ArgumentNullException.ThrowIfNull(visualizerObjectSource, "visualizerObjectSource");
			this.VisualizerTypeName = visualizerTypeName;
			this.VisualizerObjectSourceTypeName = visualizerObjectSource.AssemblyQualifiedName;
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x0014DC32 File Offset: 0x0014BE32
		[NullableContext(1)]
		public DebuggerVisualizerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type visualizer)
		{
			ArgumentNullException.ThrowIfNull(visualizer, "visualizer");
			this.VisualizerTypeName = visualizer.AssemblyQualifiedName;
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x0014DC51 File Offset: 0x0014BE51
		[NullableContext(1)]
		public DebuggerVisualizerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type visualizer, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type visualizerObjectSource)
		{
			ArgumentNullException.ThrowIfNull(visualizer, "visualizer");
			ArgumentNullException.ThrowIfNull(visualizerObjectSource, "visualizerObjectSource");
			this.VisualizerTypeName = visualizer.AssemblyQualifiedName;
			this.VisualizerObjectSourceTypeName = visualizerObjectSource.AssemblyQualifiedName;
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x0014DC87 File Offset: 0x0014BE87
		[NullableContext(1)]
		public DebuggerVisualizerAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type visualizer, [Nullable(2)] [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] string visualizerObjectSourceTypeName)
		{
			ArgumentNullException.ThrowIfNull(visualizer, "visualizer");
			this.VisualizerTypeName = visualizer.AssemblyQualifiedName;
			this.VisualizerObjectSourceTypeName = visualizerObjectSourceTypeName;
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06008957 RID: 35159 RVA: 0x0014DCAD File Offset: 0x0014BEAD
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public string VisualizerObjectSourceTypeName { get; }

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06008958 RID: 35160 RVA: 0x0014DCB5 File Offset: 0x0014BEB5
		[Nullable(1)]
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
		public string VisualizerTypeName { [NullableContext(1)] get; }

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06008959 RID: 35161 RVA: 0x0014DCBD File Offset: 0x0014BEBD
		// (set) Token: 0x0600895A RID: 35162 RVA: 0x0014DCC5 File Offset: 0x0014BEC5
		public string Description { get; set; }

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600895B RID: 35163 RVA: 0x0014DCCE File Offset: 0x0014BECE
		// (set) Token: 0x0600895C RID: 35164 RVA: 0x0014DCD6 File Offset: 0x0014BED6
		public Type Target
		{
			get
			{
				return this._target;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.TargetTypeName = value.AssemblyQualifiedName;
				this._target = value;
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600895D RID: 35165 RVA: 0x0014DCF6 File Offset: 0x0014BEF6
		// (set) Token: 0x0600895E RID: 35166 RVA: 0x0014DCFE File Offset: 0x0014BEFE
		public string TargetTypeName { get; set; }

		// Token: 0x04001E3A RID: 7738
		private Type _target;
	}
}
